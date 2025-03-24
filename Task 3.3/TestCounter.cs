using System;
using NUnit.Framework;

namespace Clock.Tests
{
    [TestFixture]
    public class TestCounter
    {
        Counter _countertest;

        [SetUp]
        public void Setup()
        {
            _countertest = new Counter("Test");
        }

        [Test]
        public void TestStart9()
        {
            Assert.That(_countertest.Tick, Is.EqualTo(0));
        }

        [Test]
        public void TestName()
        {
            Assert.That(_countertest.Name, Is.EqualTo("Test"));
        }

        [Test]
        public void TestCountReset()
        {
            _countertest.Increment();
            _countertest.Reset();
            Assert.That(_countertest.Tick, Is.EqualTo(0));
        }

        [TestCase(60, 60)]
        [TestCase(100, 100)]
        public void TestIncrement(int tick, int result)
        {
            for (int i = 0; i < tick; i++)
            {
                _countertest.Increment();
            }
            Assert.That(_countertest.Tick, Is.EqualTo(result));
        }
    }
}
