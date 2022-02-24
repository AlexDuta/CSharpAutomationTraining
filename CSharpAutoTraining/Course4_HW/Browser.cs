using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course4_HW
{
    public abstract class Browser
    {
        // Variables
        private int windowWidth;

        // Default getter & setter
        public int WindowWidth0 { get; set; }

        // Getter & setter 
        public int WindowWidth
        {
            get { return windowWidth; }
            set
            {
                if (value >= 1024 && value <= 1920)
                {
                    windowWidth = value;
                }
                else
                {
                    Console.WriteLine("Cannot set window width outside [1024,1920]!");
                }
            }
        }

        // Method to change window width (must be overridden)
        public virtual void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("Changed WindowWidth for Browser.");
        }

        // Abstract methods to be implemented by the child class Firefox
        public abstract void StartBrowser();
        public abstract void StopBrowser();
        
    }
}
