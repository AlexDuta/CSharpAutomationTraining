using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course5
{
    class Firefox : BrowserB
    {
        // Test method to access MyProtectedMethod()
        public void Test()
        {
            MyProtectedMethod();    // Protected method visible
            MyInternalMethod();     // Internal method visible
        }
    }
}
