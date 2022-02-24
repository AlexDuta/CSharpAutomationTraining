using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course5
{
    class Browser
    {
        public void FindElement()
        {
            throw new Exception("Element was not found");
        }

        public void SendTextToElement()
        {
            try
            {
                FindElement();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                BrowserHelper.CaptureScreen();
            }
            finally
            {
                BrowserHelper.PathImage = "C:/Images/img.png";
            }

        }
          
    }
}
