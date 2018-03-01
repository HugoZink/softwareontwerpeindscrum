using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	public abstract class ItemState
	{
		public virtual ItemState Start()
		{
			throw new InvalidOperationException();
		}

		public virtual ItemState Complete()
		{
			throw new InvalidOperationException();
		}

		public virtual ItemState Revert()
		{
			throw new InvalidOperationException();
		}
	}
}
