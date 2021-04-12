using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class HomePage
    {
        string Image = "//*[@id='header']/a/img";
        string HomeLink = "//*[@id='navHeader']/a";
        string Html = "/html/body/h1";
        string TextFromPage = "/html/body/p";
        string emailInput = "//*[@id='email']";
        string passwordLabel = "//*[@id='myDivHeader']/form/text()[2]";
        string loginButton = "//*[@id='Login']";
        string Home = "//*[@id='nav']/li/a";
    }
}
