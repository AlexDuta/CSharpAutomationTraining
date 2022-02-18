using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class BrowserC3
    {
        public int WindowWidth_int;
        public string WindowWidth_string;

        public virtual void ChangeWindowWidth(int val)
        {
            Console.WriteLine("BrowserC3 ChangeWindowWidth method " + val);
        }
        public virtual void About()
        {
            Console.WriteLine("BroserC3 About method");
        }
    }
}
