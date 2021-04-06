using System;

public class Class1
{
	public Class1()
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
