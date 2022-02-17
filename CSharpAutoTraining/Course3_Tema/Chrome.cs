using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course3_Tema
{
    class Chrome: Browser
    {
        public string oldVal = "1000";
        public void ChangeWindowWidth(string val)
        {
            Console.WriteLine("Old val is : "+ oldVal);
            oldVal = val;
            Console.WriteLine("New val is : " + val);
        }
    }
}
