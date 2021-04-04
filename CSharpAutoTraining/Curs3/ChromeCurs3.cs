using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class ChromeCurs3:BrowserCurs3
    {
        public void ChangeWindowsWidt(String val)
        {
            WindowWidth_string = val;
            Console.WriteLine($"New window width for Chrome is {WindowWidth_string}");
        }
        public override void About()
        {
            Console.WriteLine("The browser is Chrome");
        }
    }
}
