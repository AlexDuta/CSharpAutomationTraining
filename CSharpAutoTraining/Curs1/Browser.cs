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

        public Browser(int newWindowWitdh)
        {
            WindowWidth = newWindowWitdh;
        }

        //method
        public void changeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }
    }
}
