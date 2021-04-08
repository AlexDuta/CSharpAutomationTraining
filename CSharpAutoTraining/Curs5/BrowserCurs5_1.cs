using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
    class BrowserCurs5_1
    {
        internal void SendTextToElement()
        {
            try
            {
                FindElement();
            }
            catch (Exception e)
            {
                BrowserHelper.CaptureScreen();
            }
            finally
            {
                BrowserHelper.PathImage = "Path";
                Console.WriteLine("PathImage is: " + BrowserHelper.PathImage);
            }

        }
        public void FindElement()
        {
            throw new Exception("The element was not found!");
        }

        internal class Browser
        {
        }
    }
}
