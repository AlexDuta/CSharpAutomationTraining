﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course3
{
    class Firefox : Browser
    {
        public void SetProfile(string profileName)
        {
            WindowWidth_string = profileName;
            Console.WriteLine(WindowWidth_string);
        }
    }
}
