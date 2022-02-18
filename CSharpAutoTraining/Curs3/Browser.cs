using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    internal class Browser
    {
        public int WindowWidth_int;
        public string WindowWidth_string;

        public virtual void ChangeWindowWidth(int val)
        {
            WindowWidth_int = val;
            Console.WriteLine(WindowWidth_int);
        }

        public virtual void About() { }
    }
}
