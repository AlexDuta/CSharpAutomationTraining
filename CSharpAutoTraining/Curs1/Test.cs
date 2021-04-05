using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    class Test
    {
        public static void Main2(string[] args)
        {
            Browser browser = new Browser();
            browser.changeWindowHeight(1080);
            browser.changeWindowWidth(1920);
            browser.showWindowHeightandWidth();
            
            
        }
    }
}
