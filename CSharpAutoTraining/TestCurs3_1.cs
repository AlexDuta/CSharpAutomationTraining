using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAutoTraining.Curs3;

namespace CSharpAutoTraining
{
    public class TestCurs3_1
    {
        static void Main(string[] args)
        {
            Firefox firefox = new Firefox();
            Chrome chrome = new Chrome();
            InternetExplorer internetExplorer = new InternetExplorer();
            Edge edge = new Edge();

            Console.WriteLine("Firefox methods");
            firefox.SetProfile("testprofile");
            firefox.ChangeWindowWidth(1920);
            firefox.About();
            Console.WriteLine("Chrome methods");
            chrome.ChangeWindowWidth("3000");
            chrome.ChangeWindowWidth(1920);
            chrome.About();
            Console.WriteLine("InternetExplorer methods");
            internetExplorer.ChangeWindowWidth(1920);
            internetExplorer.About();
            Console.WriteLine("Edge methods");
            edge.ChangeWindowWidth(1920);
            edge.About();
            edge.NewFeatureFunction();

            Console.ReadLine();

        }
    }
}
