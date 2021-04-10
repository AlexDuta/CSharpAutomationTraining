using NUnit.Framework;
[TestFixture]

    public class Browser
    {
    public static bool StartBrowser(bool status)
    {
        return status;
    }
    public static string GetTitle(string OpenedBrowser)
    {
        return OpenedBrowser;
    }
    public static int GetBrowserWidth(int BrowserWidth)
    {
        return BrowserWidth;
    }
    }

