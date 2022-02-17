using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course2
{
    public class DataTypes
    {

        // Variables and their data types
        byte a1 = 255;
        sbyte a2 = -128;
        short a3 = -32765;
        ushort a4 = 65530;
        int a5 = 100;
        uint a6 = 0;
        long a7 = -98765432345678;
        ulong a8 = 12345678765432345678;
        float a9 = 0.1234567f;
        double a10 = 2.34567654d;
        decimal a11 = -76545678876533535M;
        char a12 = 'a';
        string a13 = "Course2";
        bool a14 = true;
        object a15 = 10;    // Automatically cast to int

        // Display all variables
        public void display()
        {
            Console.WriteLine("byte: " + a1 + "\n" + 
                              "sbyte: " + a2 + "\n" + 
                              "short: " + a3 + "\n" + 
                              "ushort: " + a4 + "\n" + 
                              "int: " + a5 + "\n" +
                              "uint: " + a6 + "\n" + 
                              "long: " + a7 + "\n" + 
                              "ulong: " + a8 + "\n" + 
                              "float: " + a9 + "\n" + 
                              "double: " + a10 + "\n" +
                              "decimal: " + a11 + "\n" + 
                              "char: " + a12 + "\n" + 
                              "string: " + a13 + "\n" + 
                              "bool: " + a14 + "\n" + 
                              "object: " + a15 + "\n");
        }

        // Pre Increment function
        public void PreIncrement(int x)
        {
            Console.WriteLine(x++);
        }

        // Post Increment function
        public void PostIncrement(int x)
        {
            Console.WriteLine(++x);
        }

        // Relational Operators functions
        public void PlusEq(int x, int y)
        {
            x += y;
            Console.WriteLine("+= " + x);
        }
        public void MinusEq(int x, int y)
        {
            x -= y;
            Console.WriteLine("-= " + x);
        }
        public void MulEq(int x, int y)
        {
            x *= y;
            Console.WriteLine("*= " + x);
        }
        public void DivEq(float x, float y)
        {
            x /= y;
            Console.WriteLine("/= " + x);
        }

        // If function
        public void IfStatement(int x, int y)
        {
            int value = x / y;
            if(value == 4)
            {
                Console.WriteLine(true);
            }
        }

        // If-Else function
        public void IfElseStatement(int x, int y)
        {
            int value = x / y;
            if(value == 1)
            {
                Console.WriteLine("One");
            }
            else if(value > 0)
            {
                Console.WriteLine("Positive");
            }
            else 
            {
                Console.WriteLine("Negative");
            }
        }

        // Switch-Case function
        public void SwitchCase(int x)
        {
            switch (x)
            {
                case 1:
                    {
                        Console.WriteLine("One");
                        break;
                    }
                    
                case 2:
                    {
                        Console.WriteLine("Two");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Three");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Bigger");
                        break;
                    }
                
            }
        }

        // While function
        public void WhileLoop(int i)
        {
            i = 0;
            while (i < 10)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.WriteLine();
        }

        // For function
        public void ForLoop(int x)
        {
            for(int i=0; i<x; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // Do-While function
        public void DoWhileLoop(int x)
        {
            int i = 0;
            do
            {
                Console.Write(i + " ");
                i++;
            }
            while (i < x);
            Console.WriteLine();
        }
    }
}
