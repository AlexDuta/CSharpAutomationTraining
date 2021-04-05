using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Curs3_A
{
    class BrowserCurs3_1
    {
        //variables
        public int WindowWidth_int;
        public string WindowWidth_string;

        public virtual void ChangeWindowWidth(int val)
        {
            WindowWidth_int = val;
            Console.WriteLine("The new Window width is: " + WindowWidth_int);
        }
        public virtual void About()
        {
            Console.WriteLine("Browser");
        }
    }
}
