using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary.Course7_HW
{
    class Browser
    {
        // Variables    
        bool isStarted = false;         // Status of the browser
        int BrowserWidth = 1920;        // Browser's width

        // Method to return the status of starting browser
        public bool StartBrowser()
        {
            if (isStarted)
                return false;
            return true;
        }

        // Method to return PageTitle
        public string GetPageTitle()
        {
            if (isStarted)
                return "No Browser opened.";
            return "Browser is now opened.";
        }

        // Method to return BrowserWidth value
        public int GetBrowserWidth()
        {
            return BrowserWidth;    
        }
    }
}
