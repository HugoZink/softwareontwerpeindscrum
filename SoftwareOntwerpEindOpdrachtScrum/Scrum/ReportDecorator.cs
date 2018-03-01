using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	abstract class ReportDecorator : BaseReport
	{
		protected BaseReport report;

		public ReportDecorator(BaseReport report)
		{
			this.report = report;
		}
	}
}
