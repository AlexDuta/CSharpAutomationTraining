using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary.Curs7
{
    class Browser
    {
        int BrowserWidth = 50;
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
