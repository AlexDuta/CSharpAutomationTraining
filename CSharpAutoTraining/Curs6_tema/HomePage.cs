using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6_tema
{
    internal class HomePage
    {
        string img = "//*[@id=\"header\"]/a/img";
        string homeLink = "//*[@id=\"navHeader\"]/a[contains(text(),'Home')]";
        string html = "//h1[text()='HTML']";
        string textPage = "//p[contains(text(),'HTML')]";
        string email = "//input[@id=\"email\"]";
        string password = "//*[@id=\"myDivHeader\"]/form/text()[2]";
        string loginButton = "//button[@id='Login']";
        string home = "//*[@id='nav']//a[contains(text(),'Home')]";



    }
}
