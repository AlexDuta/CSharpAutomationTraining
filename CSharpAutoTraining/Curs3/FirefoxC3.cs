using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class FirefoxC3 : BrowserC3
    {
        public void SetProfile(string profileName)
        {
            Console.WriteLine("Fireforx profile name: " + profileName);
        }
    }
}
