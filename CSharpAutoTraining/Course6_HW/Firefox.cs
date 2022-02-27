using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course6_HW
{
    class Firefox
    {
        // Variable
        public int WindowWidth;

        // Default constructor
        public Firefox()
        {
            Console.WriteLine("Default constructor.");
            WindowWidth = 1080;
        }

        // Constructor with int parameter
        public Firefox(int val)
        {
            Console.WriteLine("Constructor with int value.");
            WindowWidth = val;
        }

        // Constructor with double parameter
        public Firefox(double val)
        {
            Console.WriteLine("Constructor with double value.");
            WindowWidth = (int)val;
        }

        // Getter for WindowWidth parameter
        public int GetWindowWidth()
        {
            return WindowWidth;
        }
    }
}
