using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course6
{
    public class Firefox
    {
        public int WindowWidth;

        public Firefox()
        {

        }

        public Firefox(int val)
        {
            WindowWidth = val;
        }

        public Firefox(double val)
        {
            WindowWidth = (int)val;
        }


        public int GetWindowWidth()
        {
            return WindowWidth;
        }
    }
}
