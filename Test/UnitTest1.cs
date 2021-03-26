using Algorithm;
using NUnit.Framework;
using System;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Environment.CurrentDirectory = TestContext.CurrentContext.TestDirectory;
        }

        [Test]
        public void Test1()
        {
            var x = new MathLib().Add(1,65654652);
            Assert.AreEqual(3, x);
        }
    }
}