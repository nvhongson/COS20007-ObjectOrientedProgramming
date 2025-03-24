using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
 
namespace SwinAdventure
{
    public class TestInventory
    {
        // Item creation - shovel/sword
        Item shovel = new Item(new string[] {"shovel"},"a shovel", "This is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");


        [SetUp]
        public void Setup()
        {

        }

        [Test]
        // Test Finding Item
        public void TestFindItem()
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            Assert.IsTrue(i.HasItem(shovel.FirstID));
        }

        [Test]
        // Test Not Find Item
        public void TestNoFindItem()
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            Assert.IsFalse(i.HasItem(sword.FirstID));
        }

        [Test]
        // Test Fetching Item
        public void TestFetchItems()
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            Item fetchItem = i.Fetch(shovel.FirstID);

            Assert.IsTrue(fetchItem == shovel);
            Assert.IsTrue(i.HasItem(shovel.FirstID));
        }

        [Test]
        // Test Item Taken
        public void TestTakenItem()
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            i.Take(shovel.FirstID);
            Assert.IsFalse(i.HasItem(shovel.FirstID));
        }

        [Test]
        // Item List Test
        public void TestItemList()
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            i.Put(sword);
            Assert.IsTrue(i.HasItem(shovel.FirstID));
            Assert.IsTrue(i.HasItem(sword.FirstID));

            string expctOutput = "a shovel (shovel)\n" + "a sword (sword)\n";
            Assert.AreEqual(i.ItemList, expctOutput);
        }

    }
}
