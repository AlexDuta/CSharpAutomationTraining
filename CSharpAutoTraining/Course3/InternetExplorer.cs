using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course3
{
    public class InternetExplorer : Browser
    { 
        // Method for logging in
        public void LoginHPQ() { }

        // Method override - v1
        public override void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("Internet Explorer\n");
        }

        // Method override - v2
        public void ChangeWindowWidth(string newWindowWidth)
        {
            Console.WriteLine("Window Width changed.");
        }

        // Method override - v3
        public void ChangeWindowWidth(int newWindowWidth, string s)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("Window Width changed: " + newWindowWidth);
        }

        // Method override - v4
        public void ChangeWindowWidth(string s, int newWindowWidth)
        {
            Console.WriteLine("Window Width changed: " + newWindowWidth);
            WindowWidth = newWindowWidth;
        }
    }
}
