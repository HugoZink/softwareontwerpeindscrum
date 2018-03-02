using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	public class Item : Component
	{
		public List<Component> Components { get; private set; }

		public List<Thread> Threads { get; private set; }

		public Item() : base()
		{
			this.Components = new List<Component>();
			this.Threads = new List<Thread>();
		}

		public void AddTask(Task task)
		{
			this.Components.Add(task);
		}

		public void RemoveTask(Task task)
		{
			this.Components.Remove(task);
		}

		public override void Complete()
		{
			base.Complete();

			foreach(Component component in this.Components)
			{
				if(component.State.GetType() == typeof(ItemTodo))
				{
					component.Start();
				}
				component.Complete();
			}
		}
	}
}
