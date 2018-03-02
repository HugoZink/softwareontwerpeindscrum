using SoftwareOntwerpEindOpdrachtScrum.Scm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	public abstract class Component
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public int Points { get; set; }

		public ItemState State { get; private set; }

		public Branch Branch { get; set; }

		public Component()
		{
			this.State = BacklogStateFactory.GetInitialState();
		}

		public Component(ItemState state)
		{
			this.State = state;
		}

		public virtual void Start()
		{
			this.State = this.State.Start();
		}

		public virtual void Complete()
		{
			this.State = this.State.Complete();
		}

		public virtual void Revert()
		{
			this.State = this.State.Revert();
		}
	}
}
