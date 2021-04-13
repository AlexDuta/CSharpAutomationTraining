using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary.Curs7
{
    class BrowserCurs7
    {
        private int BrowserWidth;

        public BrowserCurs7()
        {
            this.BrowserWidth = 1920;
        }
        public Boolean StartBrowserTrue()
        {
            return true;
        }

        public Boolean StartBrowserFalse()
        {
            return false;
        }

        public string GetPageTitle()
        {
            string pageTitle = "Browser is open.";
            return pageTitle;
        }

        public int GetBrowserWidth()
        {
            return BrowserWidth;
        }
    }
}