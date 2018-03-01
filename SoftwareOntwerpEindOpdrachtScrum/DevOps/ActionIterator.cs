using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.DevOps
{
	class ActionIterator : IIterator
	{
		private List<IAction> _actions;

		private int index;

		public ActionIterator(List<IAction> actions)
		{
			this._actions = actions;
			this.index = 0;
		}

		public bool HasNext()
		{
			return this._actions.Count > index;
		}

		public object Next()
		{
			var obj = this._actions[index];
			index++;
			return obj;
		}
	}
}
