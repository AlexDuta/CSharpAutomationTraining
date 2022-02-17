using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course2_Tema
{
    internal class InternetExplorer
    {
        public int WindowWidth = 1024;
        int i = 0;
        public virtual void CompareWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            if (newWindowWidth > 1920)
            {
                while (i < 3) { 
                    i++;
                    Console.WriteLine("window width :"+newWindowWidth);
                }
            }
            else
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine("window width : "+newWindowWidth);

                }

            }

        }
    }
}
