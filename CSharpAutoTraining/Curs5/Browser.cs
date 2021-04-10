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
            try { 
                FindElement(); 
            }
            catch
            {
                BrowserHelper.CaptureScreen();

            }
            finally
            {
                BrowserHelper.PathImage = "path";
            }

        }

        public void FindElement()
        {
         
                throw new Exception("the element was not found");

        }
    }
}
