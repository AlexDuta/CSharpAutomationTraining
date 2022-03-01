//using CSharpAutoTraining.Course1;
//using CSharpAutoTraining.Course3;
//using CSharpAutoTraining.Course2_Tema;
//using CSharpAutoTraining.Course3_Tema;
//using CSharpAutoTraining.Curs4;
//using CSharpAutoTraining.Curs4_Tema;
//using CSharpAutoTraining.Curs5;
//using CSharpAutoTraining.Curs5_Tema;
//using CSharpAutoTraining.Curs6;
using CSharpAutoTraining.Curs6_tema;
using System;
using System.Collections.Generic;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {


            ///////////// curs 6 - tema  ////////
           Firefox firefox = new Firefox();
           firefox.WindowWidth = 1;
           Firefox firefox2 = new Firefox(3);      
           Firefox firefox3 = new Firefox(3.6);
           
            int x=firefox3.WindowWidth;
            Console.WriteLine(x);


            ///////////////////





            /*
            // curs 6
            var start= new Start();
            var browser = start.CreateBrowser()
                               .GetWindowWidth();

            // arrays
            string[] browsersType = { "chrome", "firefox", "ie" };
            browsersType[0] = "edge";
            for (int i = 0; i < browsersType.Length; i++)
            {
                Console.WriteLine(browsersType[i]);
            }

            foreach (var browserType in browsersType)
            {
                Console.WriteLine(browserType);
            }
            List<string> browserTypeList = new List<string>() { "chrome", "ceva" };
            browserTypeList.Add("ie");
            browserTypeList.Remove("ie");
           

            
            ////////// CURS 5 - TEMA/////////////////////
            Browser5tema browser5= new Browser5tema();
            browser5.FindElement(10);
            //browser5.FindElement(8);
            //////////////////////////////////////
            */

            //////// CURS 5 //////////
            //Math1 math = new Math1();
            //math.Division(2, 0);
            //math.Division(2, 2);

            ///////////////
            /* 

                ///// curs 4 - tema/////////////////////
                Firefox ff = new Firefox();
                ff.StartBrowser();
                ff.About();
                ff.Ping();

               Skype skype = new Skype();
                skype.About();
                skype.Ping();


                //ff.ChangeWindowWidth(1000);
               ff.WindowWidth = -1025;
                //////////////////////////////////////////////
             
            /////////Curs 4////////////////
                BrowserC5 browser5 = new BrowserC5();

                Firefox ff = new Firefox();
                InternetExplorer ie = new InternetExplorer();
                ff.About();
                ie.About();

                //  ff.ChangeWindowWidth(-1);
                ff.WindowWidth = -4;
                ///////////////////////////////

                /////////////////////// TEMA 3 ////////////////////////
                Edge edge = new Edge();
                Firefox firefox= new Firefox();
                Chrome chrome = new Chrome();
                InternetExplorer internetExplorer = new InternetExplorer();

                Console.WriteLine("Pt Firefox");
                firefox.SetProfile("Rebeca");

                Console.WriteLine("Pt Chrome");
                chrome.ChangeWindowWidth("200");

                Console.WriteLine("Pt Internet Explorer");
                internetExplorer.ChangeWindowWidth(300);

                Console.WriteLine("Pt Edge");
                edge.ChangeWindowWidth(345);
                edge.NewFeatureFunction();



                //////////////////////////////////   TEMA 2 //////////////////////////////
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