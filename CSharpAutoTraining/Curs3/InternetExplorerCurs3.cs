using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class InternetExplorerCurs3:BrowserCurs3
    {
        public override void ChangeWindowWidth(int val)
        {
            WindowWidth_int = val;
            Console.WriteLine($"New window width for this browser is {WindowWidth_int}");
        }
        public override void About()
        {
            Console.WriteLine("The browser is Internet Explorer");
        }
    }
}
