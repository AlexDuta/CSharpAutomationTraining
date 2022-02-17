//using CSharpAutoTraining.Course1;
//using CSharpAutoTraining.Course3;
using CSharpAutoTraining.Course2_Tema;
using System;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TEMA 2
            Browser browser = new Browser();
            Firefox firefox= new Firefox();
            Chrome chrome =  new Chrome();
            InternetExplorer internetExplorer = new InternetExplorer();
            int a = 10;
            string str = "abc";
            double b = 1.2;
            //int to string
            Console.WriteLine(Convert.ToString(a));

            //string to double
            //Console.WriteLine(Convert.ToDouble(str));

            //double to int
            Console.WriteLine(Convert.ToInt64(b));

            chrome.CompareWindowWidth(1800);
            chrome.CompareWindowWidth(2000);

            internetExplorer.CompareWindowWidth(1800);
            internetExplorer.CompareWindowWidth(2000);

            

            /*
            // simple Hello World program in C#
            Console.WriteLine("Hello world");
           

            Browser browser = new Browser();

            //valoare initiala
            Console.WriteLine(browser.WindowWidth);
            //schimbare valoare
            Console.WriteLine("Change width");
            browser.ChangeWindowWidth(3000);
            Console.WriteLine(browser.WindowWidth);

            //afisez size cu metoda
          //  browser.DisplayWindowWidth();

            //change window height to 1080 and width to 1920
          //  Console.WriteLine("Change size");
          //  browser.ChangeWindowWidthHeight(1980, 1920);
          //  browser.DisplayWindowWidth();

           

            byte a = 25;
            Console.WriteLine(a);

            float c = 0.123456789f;
            Console.WriteLine(c);

            decimal q = 0.123456789M;
            Console.WriteLine(q);

            object w = 6;
            Console.WriteLine(Convert.ToInt32(a));

            // post incrementare
            int r = 10;
            Console.WriteLine(r);
            Console.WriteLine(r++);
            Console.WriteLine(r);

            //pre incrementare
            Console.WriteLine(++r);
            Console.WriteLine();

            int a6 = 0;
            a6 = r + a6;
            a6 += r;
            Console.WriteLine(a6);

            // ==  egalitate 
            // = atribuire

            if (a6 == r)
            {
                Console.WriteLine("a6==r");
            }
            else if (a6 == 0)
            {
                Console.WriteLine("a6=0");
            }
            else { }

            string s1 = "a";
            string s2 = "b";
            if (s1.Equals(s2)) { }

            switch (s1)
            {
                case "a":
                    {
                        Console.WriteLine("a");
                        break;
                    }
                default: 
                    { 
                        Console.WriteLine("default");
                        break;
                    }
            }

            int index = 0;
            while(index < 10)
            {
                Console.WriteLine(index);
                index++;
            }

            do
            {
                Console.WriteLine("do while:" + index);
            }
            while (index > 10);

            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
            }

            Browser myBrowser = new Browser();
            Firefox ff= new Firefox();
            ff.ChangeWindowWidth(10);

            InternetExplorer ie = new InternetExplorer();
            ie.ChangeWindowWidth(100);
            ie.ChangeWindowWidth(1, "a");
            ie.ChangeWindowWidth("b", 3);
            ie.ChangeWindowWidth("c");

           
            */
 Console.ReadKey();
        }
    }
}