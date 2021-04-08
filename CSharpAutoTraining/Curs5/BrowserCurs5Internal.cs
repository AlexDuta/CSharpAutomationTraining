using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
    class BrowserCurs5Internal:BrowserHelper
    {
        internal void SendTextToElement()
        {
            try
            {
                FindElement();
            }
            catch (Exception e)
            {
                CaptureScreen();
            }
            finally
            {
                PathImage = "Here is the path to the image";
                Console.WriteLine(PathImage);
            }

        }
        public void FindElement()
        {
            throw new Exception("The element was not found");
        }
    }
}

