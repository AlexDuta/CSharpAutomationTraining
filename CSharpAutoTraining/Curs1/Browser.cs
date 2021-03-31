using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    class Browser
    {
        public Browser()
        {

        }

        public Browser(int newWindowHeight)
        {
            WindowHeight = newWindowHeight;
        }

       // Browser(int newWindowWidth)
       // {
       //     WindowWidth = newWindowWidth;
       // }

        //variable
        public int WindowHeight;
        public int WindowWidth;


        //method
        public void ChangeWindowHeight(int newWindowHeight)
        {
            WindowHeight = newWindowHeight;
        }

        public void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }

        public void DisplayNewWindowHeightAndWidth()
        {
            Console.WriteLine("New Browser resolution is: ");
            Console.WriteLine("New Window height is: " + WindowHeight);
            Console.WriteLine("New Window width is: " + WindowWidth);
        }
    }
}
