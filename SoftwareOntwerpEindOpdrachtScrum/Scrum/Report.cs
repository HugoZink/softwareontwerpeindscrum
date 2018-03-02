using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	public class Report : BaseReport
	{
		private string reportText;

		public Report(string text)
		{
			this.reportText = text;
		}

		public override string GetReport()
		{
			return this.reportText;
		}
	}
}
