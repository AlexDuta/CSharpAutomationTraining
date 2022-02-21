using CSharpAutoTraining.Course3;
using System;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            //// simple Hello World program in C#
            //Console.WriteLine("Hello world");

            ////Browser browser = new Browser(4000);

            ////Console.WriteLine(browser.windowWidth);
            ////browser.ChangeWindowWidth(3000);
            ////Console.WriteLine(browser.windowWidth);

            //byte a1 = 255;
            //Console.WriteLine(a1);

            //float a2 = 0.123456789f;
            //Console.WriteLine(a2);

            //decimal a3 = 0.123456789M;
            //Console.WriteLine(a3);

            //object a4 = 4;

            //Console.WriteLine(Convert.ToInt32(a1));

            //int a5 = 10;
            //Console.WriteLine(a5);
            //Console.WriteLine(a5++);
            //Console.WriteLine(a5);
            //Console.WriteLine(++a5);

            //int a6 = 0;
            //a6 = a6 + a5;
            //a6 += a5;

            //if(a6 == a5)
            //{
            //    Console.WriteLine("a6 == a5");
            //}
            //else if(a6 == 0)
            //{
            //    Console.WriteLine("a6 == 0");
            //}

            //string s1 = "a";
            //string s2 = "b";

            //if (s1.Equals(s2)) { }

            //switch(s1)
            //{
            //    case "a":
            //        {
            //            Console.Write("case == a");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("case == a1");
            //            break;
            //        }
            //}

            //int index = 0;

            //while(index < 10)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}

            //do
            //{
            //    Console.WriteLine("Do While: " + index);
            //}
            //while (index > 10);

            //for(int i = 0; i < 20; i++ )
            //{
            //    Console.WriteLine(i);
            //}

            //Browser browser = new Browser();
            //Firefox ff = new Firefox();
            //ff.ChangeWindowWidth(1);

            //InternetExplorer ie = new InternetExplorer();
            //ie.ChangeWindowWidth(1000);


            //ie.ChangeWindowWidth(1, "a");
            //ie.ChangeWindowWidth("a", 12);
            //ie.ChangeWindowWidth("a");

            //Console.ReadLine();


            //Course 2
            //Browser br = new Browser();
            //Firefox fr = new Firefox();
            //Chrome ch = new Chrome();
            //InternetExplorer ie = new InternetExplorer();

            //fr.WindowWidth_double = 25.5;
            //fr.WindowWidth_int = 25;
            //fr.WindowWidth_string = "25.6";

            //string IntToString = Convert.ToString(fr.WindowWidth_int);
            //double StringToDouble = Convert.ToDouble(fr.WindowWidth_string);
            //int DoubleToInt = Convert.ToInt32(fr.WindowWidth_double);

            //Console.WriteLine("IntToString: {0}\nStringToDouble: {1}\nDoubleToInt: {2}", IntToString, StringToDouble, DoubleToInt);

            //ch.WindowWidth_int = 2560;
            //ch.DisplayWindowWidth();
            //Console.WriteLine("\n\n");

            //ie.WindowWidth_int = 3900;
            //ie.Display3Or2();
            //Console.WriteLine("\n\n");

            //Course 3

            Firefox fr = new Firefox();
            Chrome chr = new Chrome();
            InternetExplorer ie = new InternetExplorer();
            Edge ed = new Edge();

            fr.SetProfile("New Profile");

            chr.ChangeWindowWidth("1720");

            ie.ChangeWindowWidth(2560);

            ed.NewFeatureFunction();

            Console.ReadLine();
            
        }
    }
}