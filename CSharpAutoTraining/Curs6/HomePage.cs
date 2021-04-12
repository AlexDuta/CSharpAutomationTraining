using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class HomePage
    {
        String Image = "//*[@id="header"]/a/img";
        String Homelink = "//*[@id="navHeader"]/a[1]";
        String HTML = "/html/body/h1";
        String textFromPage = "/html/body/p";
        String Email = "//*[@id="email"]";
        String passwordText = "//*[@id="myDivHeader"]/form/text()[2]";
        String Login = "//*[@id="Login"]";
        String Home = "//*[@id="nav"]/li[1]/a";
    }
}
