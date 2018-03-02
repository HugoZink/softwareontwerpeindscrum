using System;
using System.Linq;
using SoftwareOntwerpEindOpdrachtScrum.DevOps;
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

		}
	}
}
