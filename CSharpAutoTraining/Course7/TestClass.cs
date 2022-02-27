using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course7
{
    [TestFixture]
    public class TestClass
    {

        [Test]
        public void TestMethod1()
        {
            Console.WriteLine("Test method 1");
            Assert.IsTrue(2 == 2);        // Waits a Boolean type parameter
            Assert.AreEqual(true, 2 == 2, "Test method 1");
        }

        [Test]
        public void TestMethod2()
        {
            Console.WriteLine("Test method 2");
            Assert.IsTrue(true, "Test method 2");
        }
    }
}
