using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course4_HW
{
    public class Firefox : Browser, IComponent, INetwork
    {
        // Display WindowWidth value
        public void DisplayWindowWidth()
        {
            Console.WriteLine("WindowWidth: " + WindowWidth);
        }

        // Override virtual method ChangeWindowWidth()
        public override void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("Changed WindowWidth for Firefox Browser.");
        }

        // Override abstract method StartBrowser()
        public override void StartBrowser()
        {
            Console.WriteLine("Firefox Browser has been started.");
        }

        // Override abstract method StopBrowser()
        public override void StopBrowser()
        {
            Console.WriteLine("Firefox Browser has been closed.");
        }

        // Implement IComponent's method About()
        public void About()
        {
            Console.WriteLine("Firefox Browser.");
        }

        // Implement INetwork's method Ping()
        public void Ping()
        {
            Console.WriteLine("Ping Firefox Browser... Done.");
        }
    }
}
