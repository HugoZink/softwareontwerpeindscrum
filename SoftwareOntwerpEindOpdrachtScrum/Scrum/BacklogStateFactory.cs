using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	static class BacklogStateFactory
	{
		public static ItemState GetInitialState()
		{
			return new ItemTodo();
		}
	}
}
