using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    class BrowserCurs1
    {
        //variable
        public int Height = 0;
        public int Width = 0;

        //method
        public void changeWindowHeight(int newWindowHeight)
        {
            Height = newWindowHeight;
        }

        public void changeWindowWidth(int newWindowWidth)
        {
            Width = newWindowWidth;
        }

        public void showWindowHeightandWidth()
        {
            Console.WriteLine("The browser's new resolution is: " + Height + " x " + Width);
            Console.ReadKey();
        }
    }
}
