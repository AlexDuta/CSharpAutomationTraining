using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    class TestCurs1
    {
        public static void Main2(string[] args)
        {
            BrowserCurs1 browser = new BrowserCurs1();
            browser.changeWindowHeight(1080);
            browser.changeWindowWidth(1920);
            browser.showWindowHeightandWidth();
            
            
        }
    }
}
