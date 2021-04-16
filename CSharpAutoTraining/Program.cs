using CSharpAutoTraining.Curs1;
using CSharpAutoTraining.Curs3;
using System;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            // simple Hello World program in C#
            var browser = new CSharpAutoTraining.Curs1.Browser(23);


            Console.WriteLine(browser.WindowWidth);
            // browser.ChangeWindowWidth(100);
            //Console.WriteLine(browser.WindowWidth);

            //Curs2+3
            byte a1 = 23;
            object a11 = 56;
            float a2 = 1.23456777777f;
            double a3 = 1.22222222222222;
            decimal a4 = 1.8999999999998877m;
            // Console.WriteLine(Convert.ToInt32(a1));

            //Console.WriteLine(a2);

            int a5 = 10;
            Console.WriteLine(a5);
            Console.WriteLine(a5++);
            Console.WriteLine(a5);//11
            Console.WriteLine(++a5);

            int a6 = 0;
            a6 = a6 + a5;//a6+=a5;

            //int index = 9;
            //if (index == 9)
            //{
            //    Console.WriteLine("index==9");
            //}
            //else if (index < 0)
            //{
            //    Console.WriteLine("index<0");
            //}
            //else
            //{
            //    Console.WriteLine("index!=9");
            //}

            //int a7 = 9;
            //switch (a7)
            //{
            //    case 5:
            //        Console.WriteLine("switch: a7=6");
            //        break;
            //    case 8:
            //        Console.WriteLine("switch: a7=8");
            //        break;
            //    default:
            //        Console.WriteLine("switch: unknown value");
            //        break;
            //}

            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine("while: " + i);
            //    i++;
            //}

            //do
            //{
            //    Console.WriteLine("do while: " + i);
            //    i++;

            //} while (i < 5);

            //for (i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("for: " + i);
            //}

            Firefox ff = new Firefox();
            InternetExplorer ie = new InternetExplorer();
            ff.ChangeWindowWidth(1);
            ie.ChangeWindowWidth(2);
            ie.ChangeWindowWidth("test");
            ie.ChangeWindowWidth(1, 2);

            CSharpAutoTraining.Curs1_2.Browser2 br2 = new CSharpAutoTraining.Curs1_2.Browser2();

            Console.WriteLine("Hello world test");
            Console.ReadKey();
        }
    }
}