﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig03.Q01
{
    internal class Circle : ICircle
    {
        public double Area { get; set ; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine(" I am Circle");
        }
    }
}