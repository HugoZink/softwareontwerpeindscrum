using System;
using SoftwareOntwerpEindOpdrachtScrum.Scrum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftwareOntwerpTests
{
	[TestClass]
	public class SprintTests
	{
		[TestMethod]
		public void TestInitialStateOpen()
		{
			Sprint sprint = new ProxySprint();

			Assert.IsInstanceOfType(sprint.State, typeof(SprintOpen));
		}

		[TestMethod]
		public void TestStartSprint()
		{
			Sprint sprint = new ProxySprint();
			sprint.Start();

			Assert.IsInstanceOfType(sprint.State, typeof(SprintInProgress));
		}

		[TestMethod]
		public void TestCloseSprint()
		{
			Sprint sprint = new ProxySprint();
			sprint.Review = false;

			sprint.Start();
			sprint.Close();

			Assert.IsInstanceOfType(sprint.State, typeof(SprintClosed));
		}

		[TestMethod]
		public void TestCloseWithoutSummary()
		{
			Sprint sprint = new ProxySprint();
			sprint.Review = true;

			sprint.Start();

			Assert.ThrowsException<InvalidOperationException>(() => {
				sprint.Close();
			});
		}

		[TestMethod]
		public void TestEditSprintInProgress()
		{
			Sprint sprint = new ProxySprint();
			sprint.Start();

			Assert.ThrowsException<InvalidOperationException>(() => {
				sprint.StartDate = DateTime.Now;
			});
		}

		[TestMethod]
		public void TestReopenSprint()
		{
			Sprint sprint = new ProxySprint();
			sprint.Start();
			sprint.Close();

			Assert.ThrowsException<InvalidOperationException>(() => {
				sprint.Start();
			});
		}
	}
}
