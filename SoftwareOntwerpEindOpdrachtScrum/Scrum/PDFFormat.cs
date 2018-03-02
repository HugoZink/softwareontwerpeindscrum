using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	public class PDFFormat : IReportsFormat
	{
		public string Generate(BaseReport report)
		{
			return "PDF: " + report.GetReport();
		}
	}
}
