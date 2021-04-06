using System;

public class Test
{
	public Main()


         FireFox_Curs3 fireFox = new FireFox_Curs3();
    Chrome_Curs3 chrome = new Chrome_Curs3();
    InternetExplorer_Curs3 internetExplorer = new InternetExplorer_Curs3();
    Edge edge = new Edge();

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
