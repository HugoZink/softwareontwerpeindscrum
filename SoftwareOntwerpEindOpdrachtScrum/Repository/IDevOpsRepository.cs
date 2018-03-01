using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareOntwerpEindOpdrachtScrum.DevOps;

namespace SoftwareOntwerpEindOpdrachtScrum.Repository
{
	public interface IDevOpsRepository
	{
		IEnumerable<DeploymentListSchedule> Schedules { get; }

		DeploymentListSchedule GetSchedule(string name);

		void SaveSchedule(DeploymentListSchedule schedule);

		void DeleteSchedule(DeploymentListSchedule schedule);
	}
}
