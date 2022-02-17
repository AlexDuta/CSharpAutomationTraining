using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    public class Firefox : Browser
    {
        public void SetProfile(string profileName) {
            Console.WriteLine("Setting profile name:" + profileName);
        }
    }
}
