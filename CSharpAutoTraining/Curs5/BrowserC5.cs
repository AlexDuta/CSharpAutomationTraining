﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
    public class BrowserC5
    {
        class Browser
        {
            public int WindowWidth = 1024;
            //virtual permite sa fie suprascrisa in clasa copil
            public virtual void ChangeWindowWidth(int newWindowWidth)
            {
                WindowWidth = newWindowWidth;
                Console.WriteLine(" browser");
            }
        }
    }
}
