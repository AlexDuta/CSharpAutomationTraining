using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5_Tema
{
    public class Browser5tema
    {
       
           
            public void SendTextToElement() {
            FindElement(7);
             }
        
            public int n1 = 5;
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            public int FindElement(int n) {
            try
            {
                for (int i = 0; i < a.Length; i++)
                
                    if (n != a[i])
                        throw new Exception("nu este in sir");
                
            }

            catch (Exception error)
            {
                Console.WriteLine("exceptie generala");
            }
            finally
            {
                //se executa chiar daca try a dat fail
                Console.WriteLine("finally block");
            }
                return n;
            }
        
    }
}
