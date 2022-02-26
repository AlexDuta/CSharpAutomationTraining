using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    public abstract class BrowserC4
    {
        private int windowWidth;
        public int WindowWidht
        {
            get { return windowWidth; }
            set
            {
                if(value < 1024 || value > 1920)
                {
                    Console.WriteLine("Resolution value not accepted");
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
