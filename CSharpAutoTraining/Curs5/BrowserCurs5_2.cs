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
                BrowserHelp.CaptureScreeen();
            }
            finally
            {
                BrowserHelp.PathImage = "path";
                Console.WriteLine("Path Image has been set: " + BrowserHelp.PathImage);
            }

        }

        public void FindElement()
        {
            throw new Exception("The element was not found!");

        }
    }
}
