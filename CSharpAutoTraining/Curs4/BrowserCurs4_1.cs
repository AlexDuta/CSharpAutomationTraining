using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    public abstract class Browser
    {
        private int windowWidth = 1500;
        public int WindowWidth {
            get { return windowWidth; }
            set
            {
                if (value < 1024 || value > 1920)
                {
                    Console.WriteLine("The width has to be between 1024 and 1920");
                }
                else windowWidth = value;
            }
        }

        public abstract void StartBrowser();
    }
}
