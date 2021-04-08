using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class TestCurs3
    {
        static void Main(string[] args)
        {
            FireFoxCurs3 fireFox = new FireFoxCurs3();
            ChromeCurs3 chrome = new ChromeCurs3();
            InternetExplorer_Curs3 internetExplorer = new InternetExplorer_Curs3();
            Edge edge = new Edge();

            fireFox.SetProfile("Andrei Pop");
            fireFox.About();
            fireFox.ChangeWindowWidth(1920);

            chrome.ChangeWindowWidth(1680);
            chrome.About();

            internetExplorer.About();
            internetExplorer.ChangeWindowWidth(920);

            edge.About();
            edge.ChangeWindowWidth(480);
            edge.version = 2;
            edge.NewFeatureFunction();

            Console.ReadKey();

        }
    }
}
