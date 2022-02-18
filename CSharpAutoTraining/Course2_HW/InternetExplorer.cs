using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course2_HW
{
    public class InternetExplorer
    {
        // Variables
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;

        // Default constructor
        public InternetExplorer() { }

        // Constructor with parameters
        public InternetExplorer(int newWindowWidth_int, string newWindowWidth_string, double newWindowWidth_double)
        {
            WindowWidth_int = newWindowWidth_int;   
            WindowWidth_string = newWindowWidth_string; 
            WindowWidth_double = newWindowWidth_double;
        }

        // Method for setting values for int variable
        public void SetWindowWidth_int(int newWindowWidth_int)
        {
            WindowWidth_int = newWindowWidth_int;
        }

        // Method for setting values for string variable
        public void SetWindowWidth_string(string newWindowWidth_string)
        {
            WindowWidth_string = newWindowWidth_string;
        }

        // Method for setting values for double variable
        public void SetWindowWidth_double(double newWindowWidth_double)
        {
            WindowWidth_double = newWindowWidth_double;
        }

        // Method for displaying window width 2 or 3 times
        public void DisplayWindowWidth_int()
        {
            if(WindowWidth_int > 1920)
            {
                int i = 0;
                while(i < 3)
                {
                    Console.WriteLine("Window Width for IE: " + WindowWidth_int);
                    i++;
                }
            }
            else
            {
                for(int i=0; i<2; i++)
                {
                    Console.WriteLine("Window Width for IE: " + WindowWidth_int);
                }
            }
        }
    }
}
