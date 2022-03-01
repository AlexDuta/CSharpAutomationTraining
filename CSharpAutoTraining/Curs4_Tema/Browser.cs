using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4_Tema
{
    abstract class Browser
    {
        public int windowWidth = 1024;
       
        public int WindowWidth
        {
            get { return windowWidth; }
            set
            {
                if (value > 1024 && value < 1920)
                {
                    Console.WriteLine("valori in interval");
                    windowWidth = value;
                }
                else
                    Console.WriteLine("valori in afara intervalului");
            }

        }
        public virtual void ChangeWindowWidth(int newWindowWidth)
        {
            windowWidth = newWindowWidth;
            Console.WriteLine("browser- change window width");
        }
        public abstract void StartBrowser();
    }
}