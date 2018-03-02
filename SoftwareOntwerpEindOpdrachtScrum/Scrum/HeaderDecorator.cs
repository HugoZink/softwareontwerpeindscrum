using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	public class HeaderDecorator : ReportDecorator
	{
		private string _headerText;

		public HeaderDecorator(BaseReport report, string headerText) : base(report)
		{
			this._headerText = headerText;
		}

		public override string GetReport()
		{
			return _headerText + "\r\n" + this.report.GetReport();
		}
	}
}
