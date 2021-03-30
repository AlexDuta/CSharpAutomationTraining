using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    class Browser
    {
        //variable
        public int WindowWidth = 1024;
        public int Height;

        public Browser()
        {

        }

        public Browser(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }

        //method
        public void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }

        public void ChangeWindowHeight(int newHeight)
        {
            Height = newHeight;
        }

        public void DisplayWidthAndHeight()
        {
            Console.WriteLine("The new Browser resolution is: ");
            Console.WriteLine("Width: " + WindowWidth);
            Console.WriteLine("Height: " + Height);
        }
    }
}
