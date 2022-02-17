using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    public class Browser
    {
        public int WindowWidth_int;
        public string WindowWidth_string;

        public virtual void ChangeWindowWidth(int val) {
            Console.WriteLine("Browser ChangeWindowWidth");
            WindowWidth_int = val;
        }
        public virtual void About() {
            Console.WriteLine("Generic Browser");
        }
    }
}
