using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class FireFoxCurs3 : BrowserCurs3
    {

        public string Profile;
        public void SetProfile(string profileName)
        {
            this.Profile = profileName;
        }
    }
}
