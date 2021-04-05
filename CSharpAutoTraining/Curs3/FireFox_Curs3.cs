using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class FireFox_Curs3 : Browser_Curs3
    {

        public string Profile;
        public void SetProfile(string profileName)
        {
            this.Profile = profileName;
        }
    }
}
