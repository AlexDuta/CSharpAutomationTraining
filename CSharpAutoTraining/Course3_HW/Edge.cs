using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course3_HW
{
    public class Edge : InternetExplorer
    {
        // Variable
        public int version;

        // Method to set version
        public void setVersion(int newVersion)
        {
            version = newVersion;
        }

        // Method to describe the new feature's function
        public void NewFeatureFunction()
        {
            Console.WriteLine("New feature in version: " + version + "!"); ;
        }

        // Method for changing window width int value (overriden)
        public override void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth_int = newWindowWidth;
            Console.WriteLine("WindowWidth for Edge set: " + newWindowWidth);
        }

        // Method for describing browser (overrriden)
        public override void About()
        {
            Console.WriteLine("This is the Edge Browser.");
        }
    }
}
