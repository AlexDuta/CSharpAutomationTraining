using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class FirefoxCurs3_2:BrowserCurs3_1
    {
        public void SetProfile(string profileName)
        {
            Console.WriteLine("My profile name is: " + profileName);
        }
    }
}
