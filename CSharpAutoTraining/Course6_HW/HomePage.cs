using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course6_HW
{
    class HomePage
    {
        // String variables for specified XPaths
        public string image = "//*[@id=\"header\"]/a/img";
        public string homeLink = "//*[@id=\"myDivHeader\"]/header/ul/a[1]";
        public string html = "//body/h1";
        public string textFromPage = "//body/p/text()";
        public string emailText = "//*[@id=\"myDivHeader\"]/form/text()[1]";
        public string emailInput = "//body/div/form/input[@id=\"email\"]";
        public string passText = "//*[@id=\"myDivHeader\"]/form/text()[2]";
        public string passInput = "//body/div/form/input[@id=\"password\"]";
        public string loginButton = "//*[@id=\"Login\"]";
        public string home = "//footer/ul/li[1]/a";

        // Method to display XPaths
        public void DisplayXPaths()
        {
            Console.WriteLine("XPATHS: " +
                              "\n\tImage: " + image +
                              "\n\tHome Link: " + homeLink +
                              "\n\tHTML: " + html +
                              "\n\tText from Page: " + textFromPage +
                              "\n\tE-mail Text: " + emailText +
                              "\n\tE-mail Input: " + emailInput +
                              "\n\tPassword Text: " + passText +
                              "\n\tPassword Input: " + passInput +
                              "\n\tLogin Button: " + loginButton +
                              "\n\tHome Footer: " + home);
        }
         
    }
}
