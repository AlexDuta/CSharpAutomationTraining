using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course3
{
    class Browser
    {

        public int windowWidth = 1024;

        public virtual void ChangeWindowWidth(int newWindowWidth)
        {
            windowWidth = newWindowWidth;
            Console.WriteLine("Browser");
        }

    }
}
