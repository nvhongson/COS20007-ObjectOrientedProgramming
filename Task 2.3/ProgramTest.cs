using System;
using NUnit.Framework;
using Swinadventure;

namespace UnitTest
{
    [TestFixture]
    public class Tests
    {
        // Setting up the test
        [SetUp]
        public void Setup()
        {
        }

        // Setting up Are you Test
        [Test]
        public void TestAreYou()
        {
            IdentifiableObject id1 = new IdentifiableObject(new string[] { "Bob", "Freds" });
            bool testResult = id1.AreYou("Bob");
            Assert.That(testResult, Is.True);
        }

        // Setting up Are you not Test
        [Test]
        public void TestNotAreYou()
        {
            IdentifiableObject id1 = new IdentifiableObject(new string[] { "Bob", "Fred" });
            bool testResult = id1.AreYou("Boby");
            Assert.That(testResult, Is.False);
        }

        // Case sensitive Setup
        [Test]
        public void TestCaseSensitive()
        {
            IdentifiableObject id1 = new IdentifiableObject(new string[] { "Bob", "Fred" });
            bool testResult = id1.AreYou("b0B");
            Assert.That(testResult, Is.False); ;
        }

        // First ID Test
        [Test]
        public void TestFirstID()
        {
            IdentifiableObject id1 = new IdentifiableObject(new string[] { "fred", "bob" });
            bool testResult = id1.FirstID().Equals("fred", StringComparison.OrdinalIgnoreCase);
            Assert.That(testResult, Is.True);
        }
        // Test Add ID
        [Test]
        public void TestAddID()
        {
            IdentifiableObject id1 = new IdentifiableObject(new string[] { "Bob", "Franky" });
            id1.AddIdentifier("wilma");
            bool testResult = id1.AreYou("wilma");
            Assert.That(testResult, Is.True);
        }
    }
}
