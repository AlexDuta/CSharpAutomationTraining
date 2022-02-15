using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course1
{
    public class Browser
    {
        // Variable
        public int WindowWidth = 1024;

        // Default Constructor
        public Browser() { }

        // Constructor with Parameters
        public Browser(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }

        // Method
        public void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }
    }
}
