using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class Program
    {
        static void Main(string[] args)
        {
            var firefox1 = new FirefoxCurs6();
            var firefox2 = new FirefoxCurs6(1920);
            var firefox3 = new FirefoxCurs6(1920.00);

            var firefox1Width = firefox1.GetWindowWidth();
            var firefox2Width = firefox2.GetWindowWidth();
            var firefox3Width = firefox3.GetWindowWidth();

            Console.WriteLine(firefox1Width);
            Console.WriteLine(firefox2Width);
            Console.WriteLine(firefox3Width);


            Console.WriteLine("==========================================");


            Console.WriteLine(HomePage.image);
            Console.WriteLine(HomePage.homeLink);
            Console.WriteLine(HomePage.HTML);
            Console.WriteLine(HomePage.textFromPage);
            Console.WriteLine(HomePage.email);
            Console.WriteLine(HomePage.password);
            Console.WriteLine(HomePage.loginButton);
            Console.WriteLine(HomePage.home);
        }
    }
}
