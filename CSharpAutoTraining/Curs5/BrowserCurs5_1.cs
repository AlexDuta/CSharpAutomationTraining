using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
    class Browser
    {
        public void SendTextToElement()
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
                BrowserHelper.PathImage = "Test";
            }
        }
        public void FindElement()
        {
            throw new Exception("No element could be found");
        }
    }
}
