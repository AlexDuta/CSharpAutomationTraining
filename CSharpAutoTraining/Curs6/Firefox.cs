using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class Firefox
    {
        private int WindowWidth;

        public Firefox()
        {
            this.WindowWidth = 1920;
        }

        public Firefox(int val)
        {
            WindowWidth = val;
        }
        public Firefox(double val)
        {
            this.WindowWidth = Convert.ToInt32(Math.Floor(val));
        }

        public int GetWindowWidth()
        {

            return WindowWidth;
        }
    }
}
