using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Curs7
{
    internal class Browser
    {
        int BrowserWidth = 1000;
        public bool StartBrowser()
        {
            return true;
        }

        public string GetPageTitle()
        {
            return "Browser is open";
        }

        public int GetBrowserWidth()
        {
            return BrowserWidth;
        }
    }
}
