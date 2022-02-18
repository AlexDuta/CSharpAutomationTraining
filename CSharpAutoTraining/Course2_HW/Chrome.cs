using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course2_HW
{
    public class Chrome
    {
        // Variables
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;

        // Default constructor
        public Chrome() { }

        // Constructor with parameters
        public Chrome(int newWindowWidth_int, string newWindowWidth_string, double newWindowWidth_double)
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

        // Method to display WindowWidth_int
        public void DisplayWindowWidth_int()
        {
            if(WindowWidth_int > 1920)
            {
                Console.WriteLine("Window Width for Chrome: " + WindowWidth_int + ".");
            }
            else
            {
                Console.WriteLine("Window Width for Chrome: less than 1920.");
            }
        }
    }
}
