using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course1
{
    public class Browser
    {
        public int WindowWidth = 1024;

        public Browser() { }
        
        public Browser(int newWindowWidth) { WindowWidth = newWindowWidth; }
        public void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }
    }
}
