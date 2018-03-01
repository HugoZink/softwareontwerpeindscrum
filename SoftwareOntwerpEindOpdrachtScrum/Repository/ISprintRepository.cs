using SoftwareOntwerpEindOpdrachtScrum.Scrum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Repository
{
	public interface ISprintRepository
	{
		IEnumerable<Sprint> Sprints { get; }

		Sprint GetSprint(string name);

		void SaveSprint(Sprint sprint);

		void DeleteSprint(Sprint sprint);
	}
}
