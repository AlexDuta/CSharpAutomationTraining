using System;

public class Test
{
    public void Main()
    {
        Firefox_Curs3 fireFox = new Firefox_Curs3();
        Chrome_Curs3 chrome = new Chrome_Curs3();
        InternetExplorer_Curs3 internetExplorer = new InternetExplorer_Curs3();
        Edge_Curs3 edge = new Edge_Curs3();

        fireFox.SetProfile("Elena Bizau");
        fireFox.About();
        fireFox.ChangeWindowWidth(1920);

        chrome.ChangeWindowWidth(1680);
        chrome.About();

        internetExplorer.About();
        internetExplorer.ChangeWindowWidth(920);

        edge.About();
        edge.ChangeWindowWidth(480);
        edge.version = 2;
        edge.NewFeatureFunction();

        Console.ReadKey();
        {
        }
    }
}