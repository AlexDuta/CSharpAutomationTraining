using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class InternetExplorer_Curs3 : Browser_Curs3
    {
        public override void ChangeWindowWidth(int val)
        {
            this.WindowWidth_int = val;
        }
    }
}
