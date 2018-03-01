using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	class SprintInProgress : SprintState
	{
		public override SprintState Close()
		{
			return new SprintClosed();
		}
	}
}
