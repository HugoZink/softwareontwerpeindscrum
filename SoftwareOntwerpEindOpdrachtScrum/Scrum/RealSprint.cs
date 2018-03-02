using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	public class RealSprint : Sprint
	{
		public RealSprint() : base()
		{
			this.State = SprintStateFactory.GetInitialState();
		}
	}
}
