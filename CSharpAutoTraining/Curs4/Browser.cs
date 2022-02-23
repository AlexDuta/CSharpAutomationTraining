using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    internal abstract class Browser
    {
        private int windowWidth = 1920;
        public int WindowWidth
        {
            get { return windowWidth; }
            set 
            { 
                if(value >= 1024 && value <= 1920)
                {
                    windowWidth = value;
                    Console.WriteLine(value);
                } else
                {
                    Console.WriteLine("Wrong value for width");
                    
                }
            }
        }

        public abstract void StartBrowser();
    }
}
