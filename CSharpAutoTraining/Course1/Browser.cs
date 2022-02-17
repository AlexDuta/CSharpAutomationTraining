using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course1
{
    public class Browser
    {
        // Variable
        public int WindowWidth;
        public int WindowHeight;

        // Default Constructor
        public Browser() { } 

        // Constructor with width parameter
        public Browser(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }

        // Constructor with parameters
        public Browser(int newWindowWidth, int newWindowHeight)
        {
            WindowWidth = newWindowWidth;
            WindowHeight = newWindowHeight;
        }

        // Method to change window width
        public void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }

        // Method to change window height
        public void ChangeWindowHeight(int newWindowHeight)
        {
            WindowHeight = newWindowHeight;
        }

        // Method to change window width and height
        public void ChangeWindowWidthHeight(int newWindowWidth, int newWindowHeight)
        {
            WindowWidth = newWindowWidth;
            WindowHeight = newWindowHeight;
        }

        // Method to display window width
        public int DisplayWindowWidth()
        {
            return WindowWidth;
        }

        // Method to display window height
        public int DisplayWindowHeight()
        {
            return WindowHeight;
        }

        // Method to display window width and height
        public void DisplayWindowWidthHeight()
        {
            Console.WriteLine(WindowWidth + " X " + WindowHeight);
        }
    }
}
