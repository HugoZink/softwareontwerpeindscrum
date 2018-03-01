using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	abstract class BaseReport
	{
		abstract public string GetReport();

		public string GetFormattedReport()
		{
			return ReportFormatFactory.GetGenerator().Generate(this);
		}
	}
}
