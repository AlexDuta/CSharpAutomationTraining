using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course5_HW
{
    class Browser5_2
    {
        // Method to send text to element
        internal void SendTextToElement()
        {
            try
            {
                FindElement();
            }
            catch (Exception ex)
            {
                BrowserHelper.CaptureScreen();
            }
            finally
            {
                BrowserHelper.PathImage = "Path Image";
                Console.WriteLine(BrowserHelper.PathImage);
            }
        }

        // Method to find element
        public void FindElement()
        {
            throw new Exception("Element was not found!");
        }
    }
}
