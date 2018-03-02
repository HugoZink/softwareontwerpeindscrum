using System;
using SoftwareOntwerpEindOpdrachtScrum.Scrum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace SoftwareOntwerpTests
{
	[TestClass]
	public class ReportTests
	{
		[TestMethod]
		public void TestReport()
		{
			Sprint sprint = new ProxySprint();
			sprint.Name = "Test Sprint";

			BaseReport report = new Report(sprint.Name);

			Assert.AreEqual("Test Sprint", report.GetReport());
		}

		[TestMethod]
		public void TestHeader()
		{
			Sprint sprint = new ProxySprint();
			sprint.Name = "Test Sprint";

			BaseReport report = new Report(sprint.Name);

			report = new HeaderDecorator(report, "header");

			Assert.AreEqual("header\r\nTest Sprint", report.GetReport());
		}

		[TestMethod]
		public void TestFooter()
		{
			Sprint sprint = new ProxySprint();
			sprint.Name = "Test Sprint";

			BaseReport report = new Report(sprint.Name);

			report = new FooterDecorator(report, "footer");

			Assert.AreEqual("Test Sprint\r\nfooter", report.GetReport());
		}

		[TestMethod]
		public void TestHeaderFooter()
		{
			Sprint sprint = new ProxySprint();
			sprint.Name = "Test Sprint";

			BaseReport report = new Report(sprint.Name);

			report = new HeaderDecorator(report, "header");
			report = new FooterDecorator(report, "footer");

			Assert.AreEqual("header\r\nTest Sprint\r\nfooter", report.GetReport());
		}

		[TestMethod]
		public void TestReportFormatter()
		{
			IReportsFormat formatter = new FakeReportFormatter();
			Sprint sprint = new ProxySprint();
			sprint.Name = "Test Sprint";

			BaseReport report = new Report(sprint.Name);

			Assert.AreEqual("FAKETest Sprint", formatter.Generate(report));
		}

		sealed class FakeReportFormatter : IReportsFormat
		{
			public string Generate(BaseReport report)
			{
				return "FAKE" + report.GetReport();
			}
		}
	}
}
