using System;
using System.Linq;
using SoftwareOntwerpEindOpdrachtScrum.DevOps;
using SoftwareOntwerpEindOpdrachtScrum.Scm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Reflection;

namespace SoftwareOntwerpTests
{
	[TestClass]
	public class DevOpsTests
	{
		/// <summary>
		/// Cleans the ActionProviderFactory instance by setting it to null.
		/// </summary>
		private void CleanProviderFactory()
		{
			typeof(ActionProviderFactory)
				.GetField("instance", BindingFlags.Static | BindingFlags.NonPublic)
				.SetValue(null, null);
		}

		[TestMethod]
		public void TestActionProviderRegistration()
		{
			CleanProviderFactory();

			var branch1 = new Branch() { Name = "master" };
			IAction action = new Source();

			var mock = new Mock<IProvider>();
			mock.Setup(p => p.Execute(branch1));

			ActionProviderFactory.Instance.RegisterProvider<Source>(mock.Object);
			Assert.IsNotNull(ActionProviderFactory.Instance.GetProvider<Source>());
		}

		[TestMethod]
		public void TestActionProviderExecution()
		{
			CleanProviderFactory();

			var branch1 = new Branch() { Name = "master" };
			IAction action = new Source();

			var mock = new Mock<IProvider>();
			mock.Setup(p => p.Execute(branch1));

			ActionProviderFactory.Instance.RegisterProvider<Source>(mock.Object);
			ActionProviderFactory.Instance.GetProvider<Source>().Execute(branch1);

			mock.Verify(p => p.Execute(branch1));
		}

		[TestMethod]
		public void TestDeploymentSchedule()
		{
			CleanProviderFactory();

			var schedule = new DeploymentListSchedule();
			var branch = new Branch() { Name = "master" };

			schedule.Add(new Source());
			schedule.Add(new Package());

			var sourceProvider = new Mock<IProvider>();
			sourceProvider.Setup(p => p.Execute(branch));

			var packageProvider = new Mock<IProvider>();
			packageProvider.Setup(p => p.Execute(branch));

			ActionProviderFactory.Instance.RegisterProvider<Source>(sourceProvider.Object);
			ActionProviderFactory.Instance.RegisterProvider<Package>(packageProvider.Object);

			schedule.Execute(branch);

			sourceProvider.Verify(p => p.Execute(branch));
			packageProvider.Verify(p => p.Execute(branch));
		}

		[TestMethod]
		public void TestScheduleIterator()
		{
			CleanProviderFactory();

			var schedule = new DeploymentListSchedule();
			var branch = new Branch() { Name = "master" };

			schedule.Add(new Source());
			schedule.Add(new Package());

			var sourceProvider = new Mock<IProvider>();
			sourceProvider.Setup(p => p.Execute(branch));

			var packageProvider = new Mock<IProvider>();
			packageProvider.Setup(p => p.Execute(branch));

			ActionProviderFactory.Instance.RegisterProvider<Source>(sourceProvider.Object);
			ActionProviderFactory.Instance.RegisterProvider<Package>(packageProvider.Object);

			IIterator iterator = schedule.GetIterator();
			var sourceAction = iterator.Next();
			var packageAction = iterator.Next();

			Assert.IsInstanceOfType(sourceAction, typeof(Source));
			Assert.IsInstanceOfType(packageAction, typeof(Package));
		}
	}
}
