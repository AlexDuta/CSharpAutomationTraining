using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Curs3_A;

namespace ConsoleApp1.Curs3_C
{
    class FirefoxCurs3_2 : BrowserCurs3_1
    {
        public void SetProfile(String profileName)
        {
            Console.WriteLine("My profileName is: " + profileName);
        }
    }
}