using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary.Curs7
{
    class BrowserCurs7
    {
        int BrowserWidth = 10;
        public bool StartBrowser()
        {
            return true;
        }

        public string GetPageTitle()
        {
            return "Browser is open!";
        }

        public int GetBrowserWidth()
        {
            return BrowserWidth;
        }
    }
}
