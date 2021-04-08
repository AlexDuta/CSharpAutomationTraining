using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
    class BrowserCurs5_2
    {
        private void SendTextToElement()
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
                BrowserHelper.PathImage = "path";
                Console.WriteLine("Path image is: " + BrowserHelper.PathImage);
            }

        }
        public void FindElement()
        {
            throw new Exception("The element was not found!");
        }
    }
}
