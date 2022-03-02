using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SeleniumProject.Curs7
{
    internal class Browser
    {
        public bool StartBrowser()
        {
            return true;
        }
        string title = "browser is open";
        public string GetPageTitle()
        {            
            return title;
        }
        int width = 1890;
        public int GetBrowserWidth()
        {           
            return width;
        }
    }
}
