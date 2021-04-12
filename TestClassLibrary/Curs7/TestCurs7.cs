using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary.Curs7
{
    [TestFixture]
    class TestCurs7:BrowserCurs7
    {
        [Category("StartBrowserMethods")]
        [Test]
        public void StartBrowserTrue()
        {
            Assert.IsTrue(StartBrowser());
        }
        [Test]
        public void StartBrowserFalse()
        {
            Assert.IsFalse(StartBrowser());
        }
    }
}
