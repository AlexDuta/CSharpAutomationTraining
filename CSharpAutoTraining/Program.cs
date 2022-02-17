using CSharpAutoTraining.Course1;
using CSharpAutoTraining.Course2;
using System;

namespace Course1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* COURSE 1 

            // Hello World program
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            
            // Browser
            Console.WriteLine("BROWSER CLASS");
            Browser browser = new Browser(1024,2048);
            Console.Write("Resolution before change: ");
            browser.DisplayWindowWidthHeight();
            browser.ChangeWindowWidth(1920);
            browser.ChangeWindowHeight(1080);
            Console.Write("Resolution after change: ");
            browser.DisplayWindowWidthHeight();
            Console.WriteLine();

            */


            /* COURSE 2 */

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

            Console.ReadLine();
            
        }
    }
}