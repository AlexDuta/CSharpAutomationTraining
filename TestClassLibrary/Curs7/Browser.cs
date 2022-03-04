using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary.Curs7
{
    class Browser
    {

        int browserWidth;

        public Browser(int val)
        {
            browserWidth = val;
        }

        public bool StartBrowser()
        {
            return true;
        }

        public string GetPageTitle()
        {
            return "Generic Page Title";
        }

        public int GetBrowserWidth()
        {
            return browserWidth;
        }
    }
}
