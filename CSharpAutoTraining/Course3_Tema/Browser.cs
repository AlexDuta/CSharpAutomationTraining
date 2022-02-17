using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course3_Tema
{
    
    class Browser
    {
        public int WindowWidth_int = 90;
        public string WindowHeight_str = "100";

        public virtual void ChangeWindowWidth(int val) { }
        public virtual void About() { }

    }
}
