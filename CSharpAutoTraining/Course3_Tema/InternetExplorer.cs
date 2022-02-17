using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course3_Tema
{
    class InternetExplorer : Browser
    {
        public int oldVal = 100;

        public  override void ChangeWindowWidth(int val)
        {
            Console.WriteLine("Old val is : " + oldVal);
            oldVal = val;
            Console.WriteLine("New val is : " + val);
        }
    }
}
