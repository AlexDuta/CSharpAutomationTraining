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
        public int WindowWidthInt;
        public string WindowWidthString;

        public virtual void ChangeWindowWidth(int value)
        {
            WindowWidthInt = value;
            Console.WriteLine("The new Window width is: " + WindowWidthInt);
        }
        public virtual void About()
        {
            Console.WriteLine("Browser");
        }
    }
}
