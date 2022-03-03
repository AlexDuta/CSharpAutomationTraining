using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    internal class Firefox
    {
        int WindowWidth = 800;

        public Firefox() {
            Console.WriteLine("constructor1");
        }

        public Firefox(int val) {
            Console.WriteLine("constuctor2");
        }

        public Firefox(double val) {
            Console.WriteLine("constuctor3");
        }

        public int GetWindowWidth()
        {
            return WindowWidth;
        }

    }
}
