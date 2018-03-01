using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	class HtmlFormat : IReportsFormat
	{
		public string Generate(BaseReport report)
		{
			return "HTML: " + report.GetReport();
		}
	}
}
