using System;
using System.Linq;
using SoftwareOntwerpEindOpdrachtScrum.Scm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Reflection;

namespace SoftwareOntwerpTests
{
	[TestClass]
	public class ScmTests
	{
		/// <summary>
		/// Cleans the ScmProviderFactory instance by setting it to null.
		/// </summary>
		private void CleanProviderFactory()
		{
			typeof(ScmProviderFactory)
				.GetField("instance", BindingFlags.Static | BindingFlags.NonPublic)
				.SetValue(null, null);
		}

		[TestMethod]
		public void TestBranchCommit()
		{
			var branch = new Branch();
			branch.Name = "master";

			var commit = new Commit();
			commit.CommitId = "12345";
			commit.Content = "bin";
			commit.Message = "Test Commit";

			branch.Commit(commit);

			Assert.AreEqual(1, branch.Commits.Count);
			Assert.AreEqual("12345", branch.Commits.First().CommitId);
		}

		[TestMethod]
		public void TestProviderRegistration()
		{
			CleanProviderFactory();

			var branch1 = new Branch() { Name = "master" };
			var branch2 = new Branch() { Name = "develop" };

			var mock = new Mock<IScmProvider>();
			mock.Setup(p => p.Merge(branch1, branch2));
			mock.Setup(p => p.Sync(branch1));

			ScmProviderFactory.Instance.RegisterProvider(mock.Object);
			Assert.IsNotNull(ScmProviderFactory.Instance.GetProvider());
		}

		[TestMethod]
		public void TestProviderMethodCalling()
		{
			CleanProviderFactory();

			var branch1 = new Branch() { Name = "master" };
			var branch2 = new Branch() { Name = "develop" };

			var mock = new Mock<IScmProvider>();
			mock.Setup(p => p.Merge(branch1, branch2));
			mock.Setup(p => p.Sync(branch1));

			ScmProviderFactory.Instance.RegisterProvider(mock.Object);

			branch1.Merge(branch2);
			branch1.Sync();

			mock.Verify(p => p.Merge(branch1, branch2));
			mock.Verify(p => p.Sync(branch1));
		}


	}
}
