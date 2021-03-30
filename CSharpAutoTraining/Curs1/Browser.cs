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
        public int WindowHeight;
        public int WindowWidth;

        public Browser()
        {

        }

        public Browser(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }

        //method
        public void ChangeWindowHeight(int newWindowHwight)
        {
            WindowHeight = newWindowHwight;
        }

        public void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }

        public void DisplayNewWindowHeightAndWidth()
        {
            Console.WriteLine("New Browser resolution is: ");
            Console.WriteLine("New WindowHight is: " + WindowHeight);
            Console.WriteLine("New WindowWidth is: " + WindowWidth);
        }
    }
}
