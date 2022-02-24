using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course4
{
    public abstract class Browser
    {

        private int windowWidth;
        public int WindoWWidth 
        {
            get { return windowWidth;  } 
            set
            {
                if (value < 1024)
                {
                    Console.WriteLine("You can't set this to a value < 1024");
                }
                else if (value > 1920)
                {
                    Console.WriteLine("You can't set this to a value > 1920");
                }
                else
                {
                    windowWidth = value;
                }
            }
        }

        public abstract void StartBrowser();
    }
}
