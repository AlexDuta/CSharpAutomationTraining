using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
    class Program
    {
        public static void Main()
        {
            Browser browser = new Browser();
            browser.SendTextToElement();
            BrowserInternal browserInternal = new BrowserInternal();
            // browserInternal.SendTextToElement(); - class with private method
            PrivateBrowser privateBrowser = new PrivateBrowser();
           // privateBrowser.SendTextToElement(); - class with private method

        }
    }
}
