using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary.Curs7
{
    class Browser
    {
        private int BrowserWidth;

        public Browser()
        {
            this.BrowserWidth = 1920;
        }
        public Boolean StartBrowser()
        {
            return true;
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
