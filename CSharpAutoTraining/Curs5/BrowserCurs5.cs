using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
    class BrowserCurs5
    {
        public void SendTextToElement()
        {
            try
            {
                FindElement();
            }
            catch(Exception e)
            {
                BroserHelper.CaptureScreen();
            }
            finally
            {
                BroserHelper.PathImage = "path imagine";
                Console.WriteLine(BroserHelper.PathImage);
            }
        }

        public void FindElement()
        {
            throw new Exception("The element was not found");
        }
    }
}
