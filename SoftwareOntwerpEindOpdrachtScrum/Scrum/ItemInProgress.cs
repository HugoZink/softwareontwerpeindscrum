using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	class ItemInProgress : ItemState
	{
		public override ItemState Complete()
		{
			return new ItemDone();
		}
	}
}
