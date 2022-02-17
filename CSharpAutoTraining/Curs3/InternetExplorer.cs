using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    public class InternetExplorer : Browser
    {
        public override void  ChangeWindowWidth(int val)
        {
            Console.WriteLine("Internet Explorer's ChangeWindowWidth");
            WindowWidth_int = val;
        }
    }
}
