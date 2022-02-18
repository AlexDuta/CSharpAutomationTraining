using CSharpAutoTraining.Course1;
using CSharpAutoTraining.Course2;
using CSharpAutoTraining.Course2_HW;
using System;

namespace Course1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* -----------------COURSE 1-----------------
            
            // Hello World program
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            // Browser
            Console.WriteLine("BROWSER CLASS");
            Browser browser = new Browser(1024, 2048);
            Console.Write("Resolution before change: ");
            browser.DisplayWindowWidthHeight();
            browser.ChangeWindowWidth(1920);
            browser.ChangeWindowHeight(1080);
            Console.Write("Resolution after change: ");
            browser.DisplayWindowWidthHeight();
            Console.WriteLine();

            */


            /* -----------------COURSE 2-----------------  

            // Data Types
            Console.WriteLine("DATA TYPES");
            DataTypes ds = new DataTypes();
            ds.display();
            Console.WriteLine();

            // Conversions
            Console.WriteLine("PRE & POST INCREMENT");
            ds.PreIncrement(10);        // 10
            ds.PostIncrement(10);       // 11
            Console.WriteLine();

            // Operators
            Console.WriteLine("OPERATORS");
            int x = 5;
            int y = 3;
            ds.PlusEq(x, y);
            ds.MinusEq(x,y);
            ds.MulEq(x,y);
            ds.DivEq(x,y);
            Console.WriteLine();

            // If statement
            Console.WriteLine("IF STATEMENT");
            ds.IfStatement(8,2);
            Console.WriteLine();

            // If-Else statement
            Console.WriteLine("IF-ELSE STATEMENT");
            ds.IfElseStatement(4, 2);
            ds.IfElseStatement(5, -3);
            ds.IfElseStatement(7, 7);
            Console.WriteLine();

            // Switch-Case
            Console.WriteLine("SWITCH-CASE");
            ds.SwitchCase(1);
            ds.SwitchCase(2);
            ds.SwitchCase(8);
            Console.WriteLine();

            // While Loop
            Console.WriteLine("WHILE LOOP");
            ds.WhileLoop(10);
            Console.WriteLine();

            // For Loop
            Console.WriteLine("FOR LOOP");
            ds.ForLoop(10);
            Console.WriteLine();

            // Do-While Loop
            Console.WriteLine("DO-WHILE LOOP");
            ds.DoWhileLoop(10);
            Console.WriteLine();

            */


            //-----------------COURSE 2 HOMEWORK-----------------
            
            // Create objects for each class
            Browsers b = new Browsers();
            Firefox f = new Firefox();
            Chrome c = new Chrome();
            InternetExplorer ie = new InternetExplorer();

            // Set values for variables for Firefox object
            f.SetWindowWidth_int(2048);                  // Set int value
            f.SetWindowWidth_string("1920");             // Set string value
            f.SetWindowWidth_double(1080.0);              // Set double value

            // Conversions of Firefox object values
            Console.WriteLine("FIREFOX\n");
            Console.WriteLine("CONVERSIONS");
            Console.WriteLine("Int-String: " + Convert.ToString(f.WindowWidth_int));
            Console.WriteLine("String-Double: " + Convert.ToDouble(f.WindowWidth_string));
            Console.WriteLine("Double-Int: " + Convert.ToString(f.WindowWidth_double));
            Console.WriteLine("\n");

            // Show window width of Chrome
            Console.WriteLine("CHROME\n");
            c.SetWindowWidth_int(1080);         // Value less than 1920
            c.DisplayWindowWidth_int();
            c.SetWindowWidth_int(2048);         // Value larger than 1920
            c.DisplayWindowWidth_int();
            Console.WriteLine("\n");

            // Show window width of Internet Explorer
            Console.WriteLine("INTERNET EXPLORER\n");
            Console.WriteLine("VALUE < 1920");
            ie.SetWindowWidth_int(540);         // Value less than 1920
            ie.DisplayWindowWidth_int();
            Console.WriteLine();
            Console.WriteLine("VALUE > 1920");
            ie.SetWindowWidth_int(2048);        // Value larger than  1920
            ie.DisplayWindowWidth_int();
            Console.WriteLine();
             
            

            Console.ReadLine();
            
        }
    }

}