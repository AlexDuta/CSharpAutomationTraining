using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course3
{
    class InternetExplorer : Browser
    {

        //public void LoginHPQC()
        //{

        //}

        //public override void ChangeWindowWidth(int newWindowWidth)
        //{
        //    windowWidth = newWindowWidth;
        //    Console.WriteLine("InternetExplorer");
        //}

        //public void ChangeWindowWidth(string newWindowWidth)
        //{
        //    Console.WriteLine("InternetExplorer");
        //}

        //public void ChangeWindowWidth(int newWindowWidth, string a)
        //{
        //    Console.WriteLine("ABC");
        //}

        //public void ChangeWindowWidth(string a, int newWindowWidth)
        //{
        //    Console.WriteLine("Order");
        //}
        
        public override void ChangeWindowWidth(int val)
        {
            WindowWidth_int = val;
            Console.WriteLine(WindowWidth_int);
        }
    }
}
