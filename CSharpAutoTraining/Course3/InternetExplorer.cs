using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course3
{
    class InternetExplorer : Browser
    {
        public void LoginHPQC()
        {

        }
        public override void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("IE");
        }

        public void ChangeWindowWidth(string newWindowWidth)
        {

            Console.WriteLine("metoda1=overload");
        }

        public void ChangeWindowWidth(int newWindowWidth, string str1)
        {

            Console.WriteLine("metoda2=overload");
        }

        public void ChangeWindowWidth(string str1, int newWindowWidth)
        {

            Console.WriteLine("metoda3=overload");
        }
    }
}
