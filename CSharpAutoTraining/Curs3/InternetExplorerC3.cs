using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class InternetExplorerC3 : BrowserC3
    {
        public override void ChangeWindowWidth(int val)
        {
            Console.WriteLine("InternetExplorerC3 ChangeWindowWidth method " + val);
        }
    }
}
