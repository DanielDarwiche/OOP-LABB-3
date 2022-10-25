﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LABB_3
{
    class Cirkel : Geometri
    {
        protected double radie;
        protected double pi = 3.1416;
        public Cirkel(double _radie)
        {
            radie = _radie;
        }
        public Cirkel():this(5)
        {

        }
        public override double Area()
        {
            double area = (radie * 2 )* pi;
            Console.WriteLine(area);

            return area;
        }
        public double _radie
        {
            get { return radie; }
            set { radie = value; }
        }
        public double _pi { get { return pi; } }
    }
}
