using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6_tema
{
    class Firefox
    {
        public int WindowWidth;
        public Firefox()
        {
            Console.WriteLine("firefox-constructor");
        }
        public Firefox(int val)
        {
            WindowWidth = val;
            Console.WriteLine("Firefox" + WindowWidth);
            
        }
        public Firefox(double val)
        {
            WindowWidth = Convert.ToInt32(val);
            Console.WriteLine("Firefox" + WindowWidth);
        }
        public int GetWindowWidth()
        {
            return WindowWidth;
        }
    }
}
