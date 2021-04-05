using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class TestCurs3
    {
        public static void Main(string[] args)
        {
            FirefoxCurs3 firefox = new FirefoxCurs3();
            ChromeCurs3 chrome = new ChromeCurs3();
            InternetExplorerCurs3 internet = new InternetExplorerCurs3();
            EdgeCurs3 edge = new EdgeCurs3();

            firefox.About();
            firefox.ChangeWindowWidth(400);
            firefox.SetProfile("raulB");

            chrome.About();
            chrome.ChangeWindowWidth(500);
            chrome.ChangeWindowWidth("320");

            internet.About();
            internet.ChangeWindowWidth(259);

            edge.ChangeWindowWidth(345);
            edge.About();
            edge.newFeatureFunction();
            edge.version = 4;
            Console.WriteLine("Edge version is: " + edge.version);

            Console.ReadKey();
        }
    }
}
