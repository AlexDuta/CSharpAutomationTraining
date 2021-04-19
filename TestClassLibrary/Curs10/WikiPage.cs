using OpenQA.Selenium;

using NUnit.Framework;

using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace TestClassLibrary.Curs10
{
    public class WikiPage
    {
        private IWebDriver driver;

        private IWebElement wikiTextArea { get { return driver.FindElement(By.Id("htmlVersion")); } }
        private IWebElement wikiButton { get { return driver.FindElement(By.XPath("//*[@id='navHeader']/a[2]")); } }
        private IWebElement wikiH1Text { get { return driver.FindElement(By.TagName("h1")); } }
        private IWebElement wikiHtmlVersions { get { return driver.FindElement(By.Id("htmlversions")); } }

        public WikiPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void clickOnWikiButton()
        {
            wikiButton.Click();
        }

        public void writeTextInTextArea(string text)
        {
            wikiTextArea.SendKeys(text);
        }

        public void checkWikiPageHeaderText(string expectedText)
        {
            Assert.IsTrue(wikiH1Text.Displayed);
            Assert.IsTrue(wikiH1Text.Text.Equals(expectedText));
        }

        public void checkHtmlDropDownValues(string expectedValue)
        {
            SelectElement selectElement = new SelectElement(wikiHtmlVersions);

            if (expectedValue == "2")
            {
                selectElement.SelectByValue("2");
                Assert.IsTrue(wikiTextArea.Text.Equals("Current selection: 2"));
            }
            else if (expectedValue == "3.2")
            {
                selectElement.SelectByValue("3.2");
                Assert.IsTrue(wikiTextArea.Text.Equals("Current selection: 3.2"));
            }
            else if (expectedValue == "4.0")
            {
                selectElement.SelectByValue("4.0");
                Assert.IsTrue(wikiTextArea.Text.Equals("Current selection: 4.0"));
            }
            else if (expectedValue == "5")
            {
                selectElement.SelectByValue("5");
                Assert.IsTrue(wikiTextArea.Text.Equals("Current selection: 5"));
            }
        }

        public void checkWikiPageHeaderLinks()
        {
            var header = driver.FindElement(By.Id("navHeader"));
            var links = header.FindElements(By.TagName("a"));

            foreach (var e in links)
            {
                Assert.IsTrue(e.Displayed);
            }
        }

        public void checkWikiPageFooterLinks()
        {
            var header = driver.FindElement(By.Id("nav"));
            var links = header.FindElements(By.TagName("a"));

            foreach (var e in links)
            {
                Assert.IsTrue(e.Displayed);
            }
        }
    }
}
