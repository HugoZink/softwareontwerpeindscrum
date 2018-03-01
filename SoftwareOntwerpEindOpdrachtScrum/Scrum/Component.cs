using SoftwareOntwerpEindOpdrachtScrum.Scm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	abstract class Component
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

		public void Start()
		{

		}

		public void Complete()
		{

		}

		public void Revert()
		{

		}
	}
}
