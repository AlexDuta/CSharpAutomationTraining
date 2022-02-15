﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    internal class Browser
    {
        public int WindowWidth = 1024;
        public int WindowHeight = 1024;

        Browser() { }
        public Browser(int newWindowWidth, int newWindowHeight)
        {
            WindowWidth = newWindowWidth;
            WindowHeight = newWindowHeight;
        }
        public void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }

        public void ChangeWindowHeight(int newWindowHeight)
        {
            WindowHeight = newWindowHeight;
        }
    }
}
