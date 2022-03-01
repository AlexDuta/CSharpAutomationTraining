using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
     class Math1
    {
        public double Division( int num1 , int num2)
        {
            double result=0;
            try
            {
                result = num1 / num2;
                Console.WriteLine(result);
            }catch(DivideByZeroException err)
            {
                result = 0;
                Console.WriteLine("exception");
            }catch(Exception err)
            {
                Console.WriteLine("exceptie generala");
            }
            finally
            {
                //se executa chiar daca try a dat fail
                Console.WriteLine("finally block");
            }
            return result;
        }

        public void TestException()
        {
            throw new Exception("my exc");
        }
    }
}
