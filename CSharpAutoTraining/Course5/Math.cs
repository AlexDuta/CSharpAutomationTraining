using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course5
{
    class Math 
    {
        // Method
        public static double Divide(int num1, int num2)
        {
            double result = 0;
            try
            {
                result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Catching DivideByZeroException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catching all exceptions.");
            }
            finally
            {
                Console.WriteLine("Finally block.");
            }
            return result;
        }

        // Method which throws an exception
        public static void TestException()
        {
            throw new Exception("My Exception");
        }
    }
}
