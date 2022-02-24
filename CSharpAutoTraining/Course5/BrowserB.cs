using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course5
{
    public class BrowserB
    {
        // Variable
        public int WindowWidth = 1024;

        // Private method
        private void MyPrivateMethod() { }

        // Protected method
        protected void MyProtectedMethod() { }

        // Protected internal method
        protected internal void MyProtectedInternalMethod() { }

        // Internal method
        internal void MyInternalMethod() { }

        // Method to change WindowWidth parameter
        public void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            MyPrivateMethod();
        }
    }
}
