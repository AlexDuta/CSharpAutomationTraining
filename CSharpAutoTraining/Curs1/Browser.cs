using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    class Browser
    {
        //variable
        public int WindowWidth = 1024;



        //public Browser()
        //{

        //}


        public Browser(int newWidowWidth)
        {
            WindowWidth = newWidowWidth;
        }

        //method
        public void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }
    }
}
