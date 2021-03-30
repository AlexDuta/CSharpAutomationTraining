using CSharpAutoTraining.Curs1;
using System;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            Browser br = new Browser(500);
            Console.WriteLine(br.WindowWidth);
            //br.changeWindowWidth(100);
            //Console.WriteLine(br.WindowWidth);

            // simple Hello World program in C#
            Console.WriteLine("Hello world");
            Console.ReadKey();

        }
    }
}