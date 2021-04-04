using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class BrowserCurs3
    {
        public int WindowWidth_int;
        public String WindowWidth_string;

        public virtual void ChangeWindowWidth(int val)
        {
            WindowWidth_int = val;
            Console.WriteLine($"New Window width is: {WindowWidth_int}");
        }
        
        public virtual void About()
        {
            Console.WriteLine("Browser");
        }
    }
}
