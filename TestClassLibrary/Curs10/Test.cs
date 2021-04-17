using NUnit.Framework;

namespace TestClassLibrary.Curs10
{
    class Test : TestBase
    {

        [Test]
        public void test() 
       {
            string text = "HTML 5";
            string value = "2";

            HomePageScreen homePage = new HomePageScreen(driver);
            homePage.ClickOnWikiButton();

            WikiPageScreen wikiPageScreen = new WikiPageScreen(driver);
            wikiPageScreen.EnterTextInHtmlVersion(text);
            wikiPageScreen.CheckWikiTextVisibility();
            wikiPageScreen.ClickOnDropDown();
            wikiPageScreen.ChooseHtmlVersion(value);
            wikiPageScreen.CheckHomeFromHeader();
            wikiPageScreen.CheckWikiFromHeader();
            wikiPageScreen.CheckContactFromFooter();
            wikiPageScreen.CheckHomeFromFooter();
            wikiPageScreen.CheckWikiFromFooter();
       }
    }
}
