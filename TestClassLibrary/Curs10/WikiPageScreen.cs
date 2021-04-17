using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary.Curs10
{
    class WikiPageScreen
    {
        protected IWebDriver driver;

        private By htmlVersion = By.Id("htmlVersion");
        private By dropDownVersions = By.Id("htmlversions");
        private By h1TextWiki = By.XPath("/html/body/h1");
        private By headerHome = By.XPath("//*[@id='navHeader']/a[1]");
        private By headerWiki = By.XPath("//*[@id='navHeader']/a[2]");
        private By footerContact = By.XPath("//*[@id='nav']/li[3]/a");
        private By footerHome = By.XPath("//*[@id='nav']/li[1]/a");
        private By footerWiki = By.XPath("//*[@id='nav']/li[2]/a");

        public WikiPageScreen(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterTextInHtmlVersion(String text)
        {
            Utils.Browser.EnterText(driver, text, htmlVersion);
        }

        public void CheckWikiTextVisibility()
        {
            Utils.Browser.CheckElementVisibility(driver, h1TextWiki);
        }


        public void ClickOnDropDown()
        {
            Utils.Browser.ClickOnElement(driver, dropDownVersions);
        }

        public void ChooseHtmlVersion(string value)
        {
            Utils.Browser.SelectByValue(driver, dropDownVersions, value);
        }

        public void CheckHomeFromHeader()
        {
            Utils.Browser.CheckElementVisibility(driver, headerHome);

        }

        public void CheckWikiFromHeader()
        {
            Utils.Browser.CheckElementVisibility(driver, headerWiki);
        }

        public void CheckContactFromFooter()
        {
            Utils.Browser.CheckElementVisibility(driver, footerContact);
            
        }

        public void CheckHomeFromFooter()
        {
            Utils.Browser.CheckElementVisibility(driver, footerHome);

        }

        public void CheckWikiFromFooter()
        {
            Utils.Browser.CheckElementVisibility(driver, footerWiki);
        } 
    }
}
