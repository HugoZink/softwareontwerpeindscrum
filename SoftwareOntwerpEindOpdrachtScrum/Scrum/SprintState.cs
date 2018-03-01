using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	public abstract class SprintState
	{
		public virtual bool CanEdit
		{
			get
			{
				return false;
			}
		}

		public virtual SprintState Start()
		{
			throw new InvalidOperationException();
		}

		public virtual SprintState Close()
		{
			throw new InvalidOperationException();
		}
	}
}
