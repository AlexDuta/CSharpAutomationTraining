using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProj
{
    public class WikiPage
    {
        private IWebDriver driver;
        private Browser browser;

        private IWebElement PageHeaderText => driver.FindElement(By.TagName("h1"));
        private IWebElement TextAreaInput => driver.FindElement(By.Id("htmlVersion"));
        private SelectElement DropDownList => (SelectElement)driver.FindElement(By.Id("htmlversions"));

        private IWebElement Header => driver.FindElement(By.XPath("/html/body/div[1]/div/header"));

        private IWebElement Footer => driver.FindElement(By.XPath("/html/body/footer"));

        public WikiPage(IWebDriver driver)
        {
            this.driver = driver;
            browser = new Browser(driver);
        }

        public WikiPage ChechTextAreaIsDisplayed()
        {
            browser.WaitElementToBeDisplayed(driver, TextAreaInput, 5);
            Assert.AreEqual(true, TextAreaInput.Displayed);
            return this;
        }

        public WikiPage FillTextArea(string fillText)
        {
            browser.WaitElementToBeDisplayed(driver, TextAreaInput, 5);
            Assert.AreEqual(true, TextAreaInput.Displayed);
            browser.SendKeys(TextAreaInput, fillText);
            return this;
        }

        public WikiPage VerifyPageHeader(string expectedText)
        {
            Assert.AreEqual(expectedText, PageHeaderText.Text);
            return this;
        }

        public WikiPage VerifyHtmlVersion(string selectText, string expectedText)
        {
            DropDownList.SelectByText(selectText);
            Assert.AreEqual(expectedText, TextAreaInput.Text);
            return this;
        }

        //[Test]
        //public void TestH1Text()
        //{
        //    SetUp();

        //    IWebElement header = driver.FindElement(By.Id("header"));
        //    var url = header.FindElement(By.XPath(".//div/header/ul/a[2]"));



        //    url.Click();

        //    WaitElementToBeVisible(driver, By.Id("htmlVersion"));

        //    var wikiPage = driver.FindElement(By.XPath("/html/body/div[1]/div/header/ul/a[2]"));

        //    Assert.IsTrue(wikiPage.Displayed);
        //    Assert.AreEqual("WikiPage", wikiPage.Text);

        //    SelectElement dropdownList = new SelectElement(driver.FindElement(By.Id("htmlversions")));

        //    dropdownList.SelectByText("HTML 2.0");
        //    dropdownList.SelectByText("HTML 3.2");
        //    dropdownList.SelectByText("HTML 4.0");
        //    dropdownList.SelectByText("HTML 5");

        //    IWebElement footer = driver.FindElement(By.XPath("/html/body/footer/ul"));

        //    var footerLinks = footer.FindElements(By.XPath("//a"));

        //    foreach (var link in footerLinks)
        //    {
        //        Assert.IsTrue(link.Displayed);
        //    }

        //    IWebElement head = driver.FindElement(By.XPath("/html/body/div[1]/div/header"));

        //    var headerLinks = head.FindElements(By.XPath("//ul/a"));

        //    foreach (var link in headerLinks)
        //    {
        //        Assert.IsTrue(link.Displayed);
        //    }


        //}


        public WikiPage CheckHeaderLinks()
        {
            var headerLinks = Header.FindElements(By.XPath("//ul/a"));

            foreach (var link in headerLinks)
            {
                Assert.IsTrue(link.Displayed);
            }

            return this;
        }

        public WikiPage CheckFooterLinks()
        {
            var footerLinks = Footer.FindElements(By.XPath("//ul/a"));

            foreach (var link in footerLinks)
            {
                Assert.IsTrue(link.Displayed);
            }

            return this;
        }
    }

}
