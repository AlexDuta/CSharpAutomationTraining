using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    class Firefox:Browser, IComponent
    {
        public override void About()
        {
            Console.WriteLine("About Firefox");
        }

    }
}
