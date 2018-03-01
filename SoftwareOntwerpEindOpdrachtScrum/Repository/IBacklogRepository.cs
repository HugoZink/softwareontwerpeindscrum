using SoftwareOntwerpEindOpdrachtScrum.Scrum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Repository
{
	public interface IBacklogRepository
	{
		Backlog GetBacklog();

		void SaveBacklog(Backlog backlog);
	}
}
