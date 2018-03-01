using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	public abstract class Sprint : ISubject
	{
		private List<IObserver> _observers;

		public string Name { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public bool Review { get; set; }

		public Sprint()
		{
			this._observers = new List<IObserver>();
		}

		public void Attach(IObserver observer)
		{
			this._observers.Add(observer);
		}

		public void Detach(IObserver observer)
		{
			this._observers.Remove(observer);
		}

		public void NotifyObservers()
		{

		}
	}
}
