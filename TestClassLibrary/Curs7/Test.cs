using NUnit.Framework;
[TestFixture]

class Test
{
    bool TestBool = Browser.StartBrowser(false);
    bool TestBool2 = Browser.StartBrowser(true);
    string TestString = Browser.GetTitle("Browser is open");
    int TestInt = Browser.GetBrowserWidth(2);

   
    }

