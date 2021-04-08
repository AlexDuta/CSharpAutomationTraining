
using System;
internal class Browser_Curs3

{
    public int WindowWidth_int;
    public string WindowWidth_string;

    public virtual void ChangeWindowWidth(int val)
    {
        this.WindowWidth_int = val;
    }

    public virtual void About()
    {
        Console.WriteLine("this is a browser");
    }
}