using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class WikiPage
    {
        private IWebDriver driver;
        private IWebElement textArea { get { return driver.FindElement(By.Id("htmlVersion")); } }
        private IWebElement H1Heading { get { return driver.FindElement(By.XPath("//h1")); } }
        private SelectElement select { get { return new SelectElement(driver.FindElement(By.Id("htmlversions"))); } }
        private IReadOnlyCollection<IWebElement> selectElems { get { return driver.FindElement(By.Id("htmlversions")).FindElements(By.TagName("option")); } }
        private IReadOnlyCollection<IWebElement> header { get { return driver.FindElements(By.Id("navHeader")); } }
        private IReadOnlyCollection<IWebElement> footer { get { return driver.FindElements(By.Id("nav")); } }
        public WikiPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public WikiPage SendKeysToArea(string keys)
        {
            WaitForTextAreaToBeVisible();
            textArea.SendKeys(keys);
            return this;
        }
        public string FetchAreaText()
        {
            return textArea.Text;
        }
        public string FetchH1Text()
        {
            return H1Heading.Text;
        }
        public WikiPage SelectElementByText(string text)
        {
            select.SelectByText(text);
            return this;
        }
        public List<string> GetSelectOptions()
        {
            WaitForTextAreaToBeVisible();
            List<string> list = new List<string>();
            foreach(var option in selectElems)
            {
                list.Add(option.Text);
            }
            return list;
        }

        public bool isHeaderVisible()
        {
            bool flag = true;
            foreach (var elem in header)
            {
                if (!elem.Displayed)
                    flag = false;
            }
            return flag;
        }

        public bool isFooterVisible()
        {
            bool flag = true;
            foreach (var elem in footer)
            {
                if (!elem.Displayed)
                    flag = false;
            }
            return flag;
        }

        private void WaitForTextAreaToBeVisible()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(n => textArea.Displayed);
        }
    }
}
