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
        public int windowHeight;

        //constructors
        public Browser() { }

        public Browser(int newWindowWidth)
        {
            windowWidth = newWindowWidth;
        }

        //methods
        public void ChangeWindowWidth(int newWindowWidth)
        {
            windowWidth = newWindowWidth;
        }

        public void ChangeWindowHeight(int newWindowHeight)
        {
            windowHeight = newWindowHeight;
        }

        public void printWidthAndHeight()
        {
            Console.WriteLine("Window Width: {0}\nWindow Height: {1}", windowWidth, windowHeight);
            Console.ReadLine();
        }

    }
}
