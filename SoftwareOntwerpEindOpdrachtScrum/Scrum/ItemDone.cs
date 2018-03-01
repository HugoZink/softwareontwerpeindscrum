using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	class ItemDone : ItemState
	{
		public override ItemState Revert()
		{
			return new ItemTodo();
		}
	}
}
