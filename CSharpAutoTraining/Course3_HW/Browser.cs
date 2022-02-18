using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course3_HW
{
    public class Browser
    {
        // Variables
        public int WindowWidth_int;
        public string WindowWidth_string;

        // Method for changing window width int value (needs to be overriden)
        public virtual void ChangeWindowWidth(int newWindowWidth){ }

        // Method for describing browser (needs to be overrriden)
        public virtual void About() { }

    }
}
