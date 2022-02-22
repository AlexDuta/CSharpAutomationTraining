using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAutoTraining.Curs4;

namespace CSharpAutoTraining
{
    class TestCurs4_1
    {
        public static void MainCurs4(string[] args)
        {
            Firefox firefox = new Firefox() ;
            Skype skype = new Skype();
            firefox.About();
            firefox.Ping();
            skype.Ping();
            skype.About();
            firefox.WindowWidth = 1000;
            Console.WriteLine(firefox.WindowWidth);
            firefox.WindowWidth = 1920;
            Console.WriteLine(firefox.WindowWidth);
            Console.ReadLine();
        }
    }
}
