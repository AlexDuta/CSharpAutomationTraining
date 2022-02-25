using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{

    class Homepage
    {
        string image = "//*[@id=\"header\"]/a/img";
        string homelink = "//*[@id=\"navHeader\"]/a[1]";
        string HTMLText = "//body/h1";
        string Body = "//body/p";
        string Email = "//body/div/form/input[@id=\"email\"]";
        string Password = "//body/div/form/*[@id=\"password\"]";
        string Login = "//*[@id=\"Login\"]";
        string Footer = "//footer/ul/li[1]/a";
    }
}
