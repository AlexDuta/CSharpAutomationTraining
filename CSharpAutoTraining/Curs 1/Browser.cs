using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs_1
{
    class Browser
    {
        //variables
        public int WindowWidth = 1024;

        Browser()
        {

        }


        public Browser(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }



        public void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }
    }
}
