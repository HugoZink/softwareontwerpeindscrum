using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	static class ReportFormatFactory
	{
		public static IReportsFormat GetGenerator()
		{
			return new HtmlFormat();
			//return new PDFFormat();
		}
	}
}
