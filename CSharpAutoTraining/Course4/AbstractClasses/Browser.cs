using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course4.AbstractClasses
{
    public abstract class Browser
    {
        // Variable
        public int windowWidth;

        // Getter & setter
        public int WindowWidth
        {
            get { return windowWidth; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Cannot set negative value!");
                }
                else
                {
                    windowWidth = value;
                }
            }
        }

        // Method for changing window width
        public virtual void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("Generic browser method to change window width.");
        }

        // Abstract method (without implementation)
        public abstract void About();
    }
}
