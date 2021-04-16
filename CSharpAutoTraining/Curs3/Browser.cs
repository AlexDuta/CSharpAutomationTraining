using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    public class Browser
    {
        //variable
        public int WindowWidth = 1024;

        //method
        public virtual void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("Browser");
        }

        public void ChangeWindowWidth(int newWindowWidth, int newW2)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("Browser");
        }

        public void ChangeWindowWidth(int newW2, string newWindowWidth)
        {
            Console.WriteLine("Browser");
        }

        public void ChangeWindowWidth(string newWindowWidth)
        {
            Console.WriteLine("Browser");
        }
    }
}
