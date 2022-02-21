using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course3
{
    class Browser
    {

        public int WindowWidth_int;
        public string WindowWidth_string;

        public virtual void ChangeWindowWidth(int val)
        {
            WindowWidth_int = val;
            Console.WriteLine(WindowWidth_int);
        }

        public virtual void About()
        {
            Console.WriteLine(WindowWidth_int);
            Console.WriteLine(WindowWidth_string);
        }

    }
}
