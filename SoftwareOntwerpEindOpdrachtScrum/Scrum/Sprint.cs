using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	public abstract class Sprint : ISubject
	{
		protected List<IObserver> _observers;

		public virtual string Name { get; set; }

		public virtual DateTime StartDate { get; set; }

		public virtual DateTime EndDate { get; set; }

		public virtual bool Review { get; set; }

		public virtual SprintState State { get; set; }

		public virtual string ReviewSummaryDocument { get; set; }

		public Sprint()
		{
			this._observers = new List<IObserver>();
			this.State = SprintStateFactory.GetInitialState();
		}

		public virtual void Start()
		{
			this.State = this.State.Start();
			this.NotifyObservers();
		}

		public virtual void Close()
		{
			this.State = this.State.Close();
			this.NotifyObservers();
		}

		public virtual void Attach(IObserver observer)
		{
			this._observers.Add(observer);
		}

		public virtual void Detach(IObserver observer)
		{
			this._observers.Remove(observer);
		}

		public virtual void NotifyObservers()
		{
			foreach(IObserver observer in this._observers)
			{
				observer.Update(this);
			}
		}
	}
}
