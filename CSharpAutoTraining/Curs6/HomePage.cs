using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class HomePage
    {
        public String Image = "//*[@id=\"header\"]/a/img";
        public String HomeLink = "//*[@id=\"navHeader\"]/a[1]";
        public String HTML = "/html/body/h1";
        public String TextFromPage = "/html/body/p";
        public String Email = "//*[@id=\"email\"]";
        public String Password = "//*[@id=\"myDivHeader\"]/form/text()[2]";
        public String LoginButton = "//*[@id=\"Login\"]";
        public String Home = "//*[@id=\"nav\"]/li[1]/a" ;
    }
}
