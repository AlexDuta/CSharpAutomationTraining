using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class HomePage
    {
        string imagine = "//div [@id='header']/a/img";
        string homeLink= "//ul[@id='navHeader']/a [@href='homepage.html']";
        string html = "//h1";
        string textFromPage = "/html/body/p/text()";
        string email = "//*[@id='email']";
        string password = "//*[@id='password']";
        string logInButton = "//*[@id='Login']";
        string Home = "//footer/ul [@id='nav']/li/a[@href='homepage.html']";
    }
}
