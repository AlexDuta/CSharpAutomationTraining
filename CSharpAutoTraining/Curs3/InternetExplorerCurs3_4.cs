using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class InternetExplorerCurs3_4:BrowserCurs3_1
    {
        public  override void ChangeWindowWidth(int val)
        {
            Console.WriteLine("New WindowWidth: " + val);
        
        }
    }
}
