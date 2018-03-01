using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	class FooterDecorator : ReportDecorator
	{
		public FooterDecorator(BaseReport report) : base(report)
		{

		}

		public override string GetReport()
		{
			return this.report.GetReport() + "\r\nFOOTER";
		}
	}
}
