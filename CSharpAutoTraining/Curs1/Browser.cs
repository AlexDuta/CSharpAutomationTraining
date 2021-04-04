using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    class Browser
    {
        public int Height;
        public int Width;

        public void ChangeWindowHeight(int newHeight)
        {
            Height = newHeight;
        }
        public void ChangeWindowWidth(int newWidth)
        {
            Width = newWidth;
        }
        public void DisplayWindowHeight()
        {
            Console.WriteLine($"Window Height is {Height}");
        }
        public void DisplayWindowWidth()
        {
            Console.WriteLine($"Window Width is {Width}");
            Console.ReadKey();
        }
    }
}
