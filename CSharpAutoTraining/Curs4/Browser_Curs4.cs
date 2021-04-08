using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    public abstract class Browser_Curs4
    {
        private int windowWidth;

        public int WindowWidth
        {
            get { return windowWidth; }
            set
            {
                if (value >= 1024 && value <= 1920)
                {
                    windowWidth = value;
                    Console.WriteLine("WindowWidth value is: " + value);
                } else
                {
                    Console.WriteLine("Invalid value");
                }
            }
        }

        public abstract void StartBrowser();
    }
}
