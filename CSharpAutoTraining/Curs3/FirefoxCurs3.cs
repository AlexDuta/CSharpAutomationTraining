using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class FirefoxCurs3:BrowserCurs3
    {
        public void SetProfile(String ProfileName)
        {
            Console.WriteLine($"Your profile name is: {ProfileName}");
        }

        public override void About()
        {
            Console.WriteLine("The browser is Firefox");
        }
    }
}
