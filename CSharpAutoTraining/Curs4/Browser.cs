using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    abstract class Browser
    {
        private int windowWidth = 1024;
        public int WindowWidth
        {
            get { return windowWidth; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("negativ");
                }
                else 
                windowWidth = value; }
        }

        //virtual permite sa fie suprascrisa in clasa copil
        
        public virtual void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine(" browser");
        }

        public abstract void About();
    }
}
