using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary.Curs10
{
    [TestFixture]
    class TestCurs10: TestBase
    {
        public IWebDriver driver;
        public HomePage homePage;

        [Test]
        public void FillTextIntoTextAreaExplicitWait()
        {
            homePage = new HomePage(driver);
            homePage.NavigateToWikiPage().WaitToLoadExplicit().FillTextAreaField("test wiki");
        }        
        
        [Test]
        public void FillTextIntoTextAreaFluentWait()
        {
            homePage = new HomePage(driver);
            homePage.NavigateToWikiPage().WaitToLoadFluent().FillTextAreaField("test wiki");
        }        
        
        [Test]
        public void FillTextIntoTextAreaImplicitWait()
        {
            homePage = new HomePage(driver);
            homePage.NavigateToWikiPage().WaitToLoadImplicit().FillTextAreaField("test wiki");
  
        }

    }
}
