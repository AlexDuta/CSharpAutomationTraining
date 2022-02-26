using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
    class BrowserC5b
    {
        private String SendTextToElement()
        {
            var PathImage = "";

            try
            {
                FindElement();
            }
            catch (Exception e)
            {
                Console.WriteLine("(BrowserC5b)Exception caught: " + e);
                BrowserHelper.CaptureScreen();
            }
            finally
            {
                PathImage = BrowserHelper.PathImage;
            }
            return PathImage;
        }
        public void FindElement()
        {
            throw new Exception("ElementNotFoundException");
        }
    }
}
