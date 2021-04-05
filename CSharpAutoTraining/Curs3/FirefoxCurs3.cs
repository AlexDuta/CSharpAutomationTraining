using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class FirefoxCurs3 : BrowserCurs3
    {
        public void SetProfile(string profileName) 
        {
            Console.WriteLine("The firefox profile name is: " + profileName);
        }
    }
}
