using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
namespace TestClassLibrary.Curs10
{
    [TestFixture]
    class TestCurs11_1 : TestBase11_1
    {
        [Test]
        public void navigateTest()
        {
            homePage.WikiPageClick().SendKeysToArea("Hello World");
        }
    }
}
