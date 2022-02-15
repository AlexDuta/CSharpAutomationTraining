using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course1
{
    public class Browser
    {
        public int WindowWidth = 1024;
        public int WindowHeight = 768;
        public Browser() { }
        
        public Browser(int newWindowWidth) { WindowWidth = newWindowWidth; }
        public Browser(int newWindowWidth, int newWindowHeight) 
        { 
            WindowWidth = newWindowWidth; 
            WindowHeight = newWindowHeight;
        }
        public void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }
        public void ChangeWindowHeight(int newWindowHeight)
        {
            WindowHeight = newWindowHeight;
        }
        public void DisplayResolution()
        {
            Console.WriteLine("Browser Resolution is " + WindowWidth + "x" + WindowHeight);
        }
    }
}
