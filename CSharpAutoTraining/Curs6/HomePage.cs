using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class HomePage
    {
        String image = "//*[@id="header"]/a/img";
        String homeLink = "//*[@id="navHeader"]/a[1]";
        String html = "/html/body/h1";
        String textFromPage = "/html/body/p";
        String email = "//*[@id="email"]";
        String password = "//*[@id="myDivHeader"]/form/text()[2]";
        String loginButton = "//*[@id="Login"]";
        String home = "//*[@id="nav"]/li[1]/a";
    }
}
