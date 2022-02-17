using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course3_Tema
{
    class Firefox : Browser
    {
        public string oldProfileName = "Annna";

        public void SetProfile(string profileName)
        {
          Console.WriteLine(" Old name is : " + oldProfileName);
          oldProfileName = profileName;
          Console.WriteLine(" New name is : " + profileName);
        }
    }

}
