using CoreProject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    //page object class
     class Homepage
    {
        // elementele de pe pagina
        private IWebDriver driver;
        private Browser browser;
        private By EmailInputBy = By.Id("email");
        private IWebElement EmailInput { get { return driver.FindElement(EmailInputBy); } }
        private IWebElement PasswordInput => driver.FindElement(By.Id("password"));
        private IWebElement LoginBtn => driver.FindElement(By.Id("Login"));
        private IWebElement WikiLink => driver.FindElement(By.XPath("//header//*[@href='wikipage.html']"));

        //constructor
        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            browser = new Browser(driver);
        }
        
        //metode functionale - care fac ceva cu elementele de pe pagina 
        public Homepage FillInLoginDetails(string email , string password)
        {
            browser.SendKeys(EmailInput, email);
            PasswordInput.SendKeys(password);
            return this;
        }

        public DashBoardPage ClickLoginBtn()
        {
            LoginBtn.Click();
            return new DashBoardPage(driver);
        }

        public WikiPage clickWikiLink()
        {
            WikiLink.Click();
            return new WikiPage(driver);
        }
    }
}
