﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gott imperator = Gott.erscheine();

            imperator.sprich(); 
        }
    }
}
