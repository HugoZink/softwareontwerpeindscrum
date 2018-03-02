using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	public class FooterDecorator : ReportDecorator
	{
		private string _footerText;

		public FooterDecorator(BaseReport report, string footerText) : base(report)
		{
			this._footerText = footerText;
		}

		public override string GetReport()
		{
			return this.report.GetReport() + "\r\n" + _footerText;
		}
	}
}
