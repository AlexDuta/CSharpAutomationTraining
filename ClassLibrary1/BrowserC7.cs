using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ClassLibrary1
{
    
    public class BrowserC7
    {
        public bool StartBrowser()
        {
            return true;
        }
        public String GetPageTitle()
        {
            return "Browser is open";
        }
        public int GetBrowserWidth()
        {
            return 1920;
        }
    }
}
