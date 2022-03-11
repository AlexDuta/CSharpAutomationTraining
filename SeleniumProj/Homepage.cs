using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProj
{
    public class Homepage
    {
        private IWebDriver driver;
        private Browser browser;

        private By EmailInputBy = By.Id("email");
        private IWebElement EmailInput { get { return driver.FindElement(By.Id("email"));  } }
        private IWebElement PasswordInput => driver.FindElement(By.Id("password"));
        private IWebElement LoginBtn => driver.FindElement(By.Id("Login"));
        private IWebElement WikiLink => driver.FindElement(By.XPath("//*[@href='wikipage.html']"));


        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            browser = new Browser(driver);
        }

        public Homepage FillInLoginDetails(string email, string password)
        {
            browser.SendKeys(EmailInput, email);
            PasswordInput.SendKeys(password);

            return this;
        }

        public DashboardPage ClickLoginBtn()
        {
            LoginBtn.Click();
            return new DashboardPage(driver);
        }

        public WikiPage ClickWikiLink()
        {
            WikiLink.Click();
            return new WikiPage(driver);
        }

    }
}
