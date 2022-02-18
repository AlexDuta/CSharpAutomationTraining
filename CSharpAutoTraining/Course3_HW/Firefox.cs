using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course3_HW
{
    public  class Firefox : Browser
    {
        // Variable
        public string profileName;

        // Method to set profile for browser
        public void setProfile(string newProfileName)
        {
            profileName = newProfileName;
        }

        // Method to get profile for browser
        public string getProfile()
        {
            return profileName;
        }

        // Method for changing window width int value (overriden)
        public override void ChangeWindowWidth(int newWindowWidth) 
        {
            WindowWidth_int = newWindowWidth;
            Console.WriteLine("WindowWidth for Firefox set: " + newWindowWidth);
        }

        // Method for describing browser (overrriden)
        public override void About() {
            Console.WriteLine("This is the Firefox Browser.");
        }
    }
}
