using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
    internal class Browser5_2
    {
        internal void SendTextToElement()
        {
            try
            {
                FindElement();
            }
            catch (Exception)
            {
                BrowserHelper.CaptureScreen();

            }
            finally
            {
                BrowserHelper.PathImage = "C";
                Console.WriteLine(BrowserHelper.PathImage);
            }
        }
        public void FindElement()
        {
            throw new Exception("The element was not found!");


        }
    }
}
