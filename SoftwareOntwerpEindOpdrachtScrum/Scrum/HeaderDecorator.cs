using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	class HeaderDecorator : ReportDecorator
	{
		public HeaderDecorator(BaseReport report) : base(report)
		{

		}

		public override string GetReport()
		{
			return "HEADER\r\n" + this.report.GetReport();
		}
	}
}
