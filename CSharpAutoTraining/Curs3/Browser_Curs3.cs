using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class Browser_Curs3
    {
        public int WindowWidth_int;
        public string WindowWidth_string;

        public virtual void ChangeWindowWidth(int val)
        {
            this.WindowWidth_int = val;
        }

        public virtual void About()
        {
            Console.WriteLine("This is a browser.");
        }
    }
}
