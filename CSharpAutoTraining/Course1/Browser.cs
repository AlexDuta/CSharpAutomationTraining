using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course1
{
     class Browser
    {
        // variable
        public int WindowWidth = 1024;
        public int WindowHeight = 1000;
        //method
        
        public void ChangeWindowWidth( int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }
        public void DisplayWindowWidth()
        {
            Console.WriteLine("Window width: "+WindowWidth+ " and height: "+ WindowHeight);
           
        }
        public void ChangeWindowWidthHeight(int newWindowWidth, int newWindowHeight)
        {
            WindowWidth = newWindowWidth;
            WindowHeight = newWindowHeight;
        }
    }
}
