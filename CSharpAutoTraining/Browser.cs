using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining
{

    class Browser
    {
       private double Height = 0;
       private double Width = 0;

        public void DisplayHeightAndWidth()
        {
            Console.WriteLine("Height " + Height + ", width "+ Width);

        }
        public void ChangeWindowHeight(double Height)
        {
            this.Height = Height;

        }
        public void ChangeWindowWidth(double Width)
        {
            this.Width = Width;
        }


    }
}
