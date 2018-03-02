using System;
using SoftwareOntwerpEindOpdrachtScrum.Scrum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftwareOntwerpTests
{
	[TestClass]
	public class SprintTests
	{
		[TestMethod]
		public void TestInitialState()
		{
			Sprint sprint = new ProxySprint();

			//Assert.IsInstanceOfType(sprint.State, typeof(SprintOpen));
		}
	}
}
