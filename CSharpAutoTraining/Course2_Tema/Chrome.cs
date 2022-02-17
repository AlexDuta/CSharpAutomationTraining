using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course2_Tema
{
    internal class Chrome
    {
        public int WindowWidth = 1024;
        public virtual void CompareWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            if(newWindowWidth > 1920)
            {
                Console.WriteLine("window width higher the 1920 ");
            }
            else
            {
                Console.WriteLine("window width less the 1920 ");

            }
           
        }
    }
}
