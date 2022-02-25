using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs7
{
    class BrowserCurs7_1
    {
        bool started = false;
        int WindowWidth = 1920;
        public bool StartBrowser()
        {
            if (started)
                return false;
            started = true;
            return true;
        }
        public string GetPageTitle()
        {
            if(started)
                return "Browser is open";
            return "No page";
        }

        public int GetBrowserWidth()
        {
            return WindowWidth;
        }
    }
}
