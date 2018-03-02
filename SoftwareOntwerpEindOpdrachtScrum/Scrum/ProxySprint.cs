using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	public class ProxySprint : Sprint
	{
		private RealSprint _realSprint;

		public override string Name
		{
			get
			{
				return _realSprint.Name;
			}
			set
			{
				if(!_realSprint.State.CanEdit)
				{
					throw new InvalidOperationException("Sprints cannot be edited once started!");
				}

				_realSprint.Name = value;
			}
		}

		public override DateTime StartDate
		{
			get
			{
				return _realSprint.StartDate;
			}
			set
			{
				if (!_realSprint.State.CanEdit)
				{
					throw new InvalidOperationException("Sprints cannot be edited once started!");
				}

				_realSprint.StartDate = value;
			}
		}

		public override DateTime EndDate
		{
			get
			{
				return _realSprint.EndDate;
			}
			set
			{
				if (!_realSprint.State.CanEdit)
				{
					throw new InvalidOperationException("Sprints cannot be edited once started!");
				}

				_realSprint.EndDate = value;
			}
		}

		public override bool Review
		{
			get
			{
				return _realSprint.Review;
			}
			set
			{
				if (!_realSprint.State.CanEdit)
				{
					throw new InvalidOperationException("Sprints cannot be edited once started!");
				}

				_realSprint.Review = value;
			}
		}

		public override SprintState State
		{
			get
			{
				return _realSprint.State;
			}
			set
			{
				_realSprint.State = value;
			}
		}

		public override string ReviewSummaryDocument
		{
			get
			{
				return _realSprint.ReviewSummaryDocument;
			}
			set
			{
				_realSprint.ReviewSummaryDocument = value;
			}
		}

		public ProxySprint()
		{
			this._realSprint = new RealSprint();
		}

		public override void Start()
		{
			_realSprint.Start();
		}

		public override void Close()
		{
			//If this sprint is closed with a review, check if a document has been uploaded.
			if(this.Review && this.ReviewSummaryDocument == null)
			{
				throw new InvalidOperationException("A summary document of the sprint review has not been uploaded yet!");
			}

			this._realSprint.Close();
		}

		public override void Attach(IObserver observer)
		{
			_realSprint.Attach(observer);
		}

		public override void Detach(IObserver observer)
		{
			_realSprint.Detach(observer);
		}

		public override void NotifyObservers()
		{
			_realSprint.NotifyObservers();
		}
	}
}
