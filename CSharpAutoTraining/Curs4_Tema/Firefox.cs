using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4_Tema
{
     class Firefox: Browser ,IComponent
    {
        public override void StartBrowser()
        {
            Console.WriteLine("Start Browser Firefox");
        }

        public void About()
        {
            Console.WriteLine("about firefox");
        }

        public void Ping()
        {
            Console.WriteLine("firefox ping");
        }
    }
}
