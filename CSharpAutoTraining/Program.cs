using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAutoTraining.A;
using CSharpAutoTraining.B;
using CSharpAutoTraining.C;
using CSharpAutoTraining.Curs4;
using CSharpAutoTraining.D;

namespace CSharpAutoTraining
{
    class Program
    {
        public static void Main(String[] args)
        {
            //---------------Homework Curs 4---------------------------

            Curs4.Firefox firefox = new Curs4.Firefox();
            Skype skype = new Skype();

            firefox.Ping();
            firefox.About();
            firefox.WindowWidth = 1300;
            firefox.StartBrowser();
            skype.Ping();
            skype.About();
            Console.ReadKey();

            //----------------Homework Curs 3-------------------------

            /* Browser browser = new Browser();
             Firefox firefox = new Firefox();
             Chrome chrome = new Chrome();
             InternetExplorer internerExplorer = new InternetExplorer();

             firefox.DisplayConvertWidth();
             chrome.DisplayWindowWidth();
             internerExplorer.DisplayWindowW();
             Console.ReadKey();

             var browserCurs3_1 = new Curs3.BrowserCurs3_1();
             var fireFoxCurs3_2 = new Curs3.FirefoxCurs3_2();
             var chromeCurs3_3 = new Curs3.ChromeCurs3_3();
             var internetExplorerCurs3_4 = new Curs3.InternetExplorerCurs3_4();
             var edge = new Curs3.Edge();

             browserCurs3_1.ChangeWindowWidth(5);
             fireFoxCurs3_2.SetProfile("profileA");
             chromeCurs3_3.ChangeWindowWidth("NEWWindow");
             internetExplorerCurs3_4.ChangeWindowWidth(6);
             edge.NewFeatureFunction();
             Console.ReadKey();*/
        }
    }

   
}
