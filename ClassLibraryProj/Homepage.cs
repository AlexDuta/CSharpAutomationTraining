using ClassLibrary3;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProj
{
    public class Homepage
    {

        private IWebDriver driver;
        private Browser browser;
        //elements

        private IWebElement EmailInput { get { return driver.FindElement(By.Id("email")); } }
        private IWebElement PasswordInput { get { return driver.FindElement(By.Id("password")); } }
        private IWebElement PasswordErrorMsg { get { return driver.FindElement(By.Id("passwordErrorText")); } }
        private IWebElement WikiLink { get { return driver.FindElement(By.XPath("//*[@id='navHeader']//a[@href='wikipage.html']")); } }

        private By LoginBtnBy = By.Id("Login");
        private IWebElement LoginBtn { get { return driver.FindElement(LoginBtnBy); } }



        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            browser = new Browser(driver);
        }


        //metode
        public Dashboardpage LoginWithSuccess(string email, string password)
        {
            // EmailInput.SendKeys(email);
            browser.CustomSendKeys(EmailInput, email);
            PasswordInput.SendKeys(password);
            LoginBtn.Click();
            return new Dashboardpage(driver);
        }

        public Homepage FillInLoginDetails(string email, string password)
        {
            browser.CustomSendKeys(EmailInput, email);
            PasswordInput.SendKeys(password);
            return this;
        }

        public Dashboardpage ClickLoginBtn()
        {
            LoginBtn.Click();
            return new Dashboardpage(driver);
        }

        public Homepage ClickLoginBtnNegative()
        {
            LoginBtn.Click();
            return this;
        }

        public Homepage CheckPasswordErrorMsgDisplayed()
        {
            Assert.IsTrue(PasswordErrorMsg.Displayed);
            return this;
        }

        public WikiPage NavigateToWikiPage()
        {
            WikiLink.Click();
            return new WikiPage(driver);
        }
    }
}
