using System;
using System.Linq;
using SoftwareOntwerpEindOpdrachtScrum.Scrum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace SoftwareOntwerpTests
{
	[TestClass]
	public class BacklogItemTests
	{
		[TestMethod]
		public void TestInitialItemState()
		{
			Component item = new Item();

			Assert.IsInstanceOfType(item.State, typeof(ItemTodo));
		}

		[TestMethod]
		public void TestItemStart()
		{
			Component item = new Item();
			item.Start();

			Assert.IsInstanceOfType(item.State, typeof(ItemInProgress));
		}

		[TestMethod]
		public void TestItemDone()
		{
			Component item = new Item();
			item.Start();
			item.Complete();

			Assert.IsInstanceOfType(item.State, typeof(ItemDone));
		}

		[TestMethod]
		public void TestItemRevert()
		{
			Component item = new Item();
			item.Start();
			item.Complete();
			item.Revert();

			Assert.IsInstanceOfType(item.State, typeof(ItemTodo));
		}

		[TestMethod]
		public void TestItemInvalidCompletion()
		{
			Component item = new Item();

			Assert.ThrowsException<InvalidOperationException>(() => {
				item.Complete();
			});
		}

		[TestMethod]
		public void TestItemInvalidRevert()
		{
			Component item = new Item();
			item.Start();

			Assert.ThrowsException<InvalidOperationException>(() => {
				item.Revert();
			});
		}

		[TestMethod]
		public void TestTaskAutoComplete()
		{
			Item item = new Item();
			item.AddTask(new Task());
			item.AddTask(new Task());

			item.Start();
			item.Complete();

			Assert.AreEqual(2, item.Components.Count);
			Assert.IsInstanceOfType(item.Components.First().State, typeof(ItemDone));
		}

		[TestMethod]
		public void TestTaskRemoval()
		{
			Item item = new Item();

			var task1 = new Task() { Name = "test 1" };
			var task2 = new Task() { Name = "test 2" };

			item.AddTask(task1);
			item.AddTask(task2);
			item.RemoveTask(task2);

			Assert.AreEqual(1, item.Components.Count);
			Assert.AreEqual("test 1", item.Components[0].Name);
		}
	}
}
