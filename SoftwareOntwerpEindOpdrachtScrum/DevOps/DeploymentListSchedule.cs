using SoftwareOntwerpEindOpdrachtScrum.Scm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.DevOps
{
	public class DeploymentListSchedule
	{
		public List<IAction> Actions { get; private set; }

		public DeploymentListSchedule()
		{
			this.Actions = new List<IAction>();
		}

		public void Add(IAction action)
		{
			this.Actions.Add(action);
		}

		public void Remove(IAction action)
		{
			this.Actions.Remove(action);
		}

		public IIterator GetIterator()
		{
			return new ActionIterator(Actions);
		}

		public void Execute(Branch branch)
		{
			IIterator iterator = this.GetIterator();

			while(iterator.HasNext())
			{
				IAction action = iterator.Next() as IAction;
				action.Execute(branch);
			}
		}
	}
}
