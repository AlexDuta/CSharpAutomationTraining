using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAutoTraining.Curs1;

namespace CSharpAutoTraining.Curs1
{
    class Test
    {
        public static void Main(String[] args)
        {
            Browser browser = new Browser();
            browser.ChangeWindowHeight(1080);
            browser.ChangeWindowWidth(1920);
            browser.DisplayWindowHeight();
            browser.DisplayWindowWidth();
        }
    }
}
