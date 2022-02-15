using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course1
{
    public class Browser
    {
        //vars
        public int windowWidth = 1024;


        public Browser() { }

        public Browser(int newWindowWidth)
        {
            windowWidth = newWindowWidth;
        }
        //method
        public void ChangeWindowWidth(int newWindowWidth)
        {
            windowWidth = newWindowWidth;
        }
    }
}
