using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    internal class InternetExplorer:Browser
    {
        public override void ChangeWindowWidth(int val)
        {
            val++;
            Console.WriteLine(val);

        }
    }
}
