using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
   
   
    public abstract class Browser
    {
        private int windowWidth;
        public int WindowWidth
        {
            get
            {
                return windowWidth;
            }

            set
            {
                if(value >= 1024 && value <= 1920)
                {
                    windowWidth = value;
                }
                else
                {
                    Console.WriteLine("Value should be between 1024 and 1920");

                }
            }
        }


        public abstract void StartBrowser();
    }
}
