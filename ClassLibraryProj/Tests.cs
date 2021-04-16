using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProj
{
    class Tests : BaseTest
    {

        [Test]
        public void TestLogin()
        {
            Homepage homepage = new Homepage(driver);
            //homepage.LoginWithSuccess("admin@domain.org", "111111");
            Dashboardpage dashboardPage = homepage.FillInLoginDetails("admin@domain.org", "111111")
                                                  .ClickLoginBtn()
                                                  .VerifyPageHeader("Dashboard page");
            //Assert.AreEqual("Dashboard page", dashboardPage.GetPageHeaderText());
        }

        [Test]
        public void TestLoginNegative()
        {
            Homepage homepage = new Homepage(driver);
            //homepage.LoginWithSuccess("admin@domain.org", "111111");
            homepage.FillInLoginDetails("admin@domain.org", "").ClickLoginBtnNegative().CheckPasswordErrorMsgDisplayed();
        }

        [Test]
        public void TestWikiLink()
        {
            Homepage homepage = new Homepage(driver);
            homepage.NavigateToWikiPage().VerifyPageHeaderText("WikiPage");
        }


    }
}
