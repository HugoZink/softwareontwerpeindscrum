using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	class SprintOpen : SprintState
	{
		public bool CanEdit
		{
			get
			{
				return true;
			}
		}

		public override SprintState Start()
		{
			return new SprintInProgress();
		}
	}
}
