﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LABB_3
{
    class Cirkel : Geometri
    {
        protected double radie;
        protected double pi = 3.1416;//skapar variablerna och konstruktorer som är skyddade och kan användas
        public Cirkel(double _radie)
        {
            radie = _radie;
        }
        public Cirkel():this(5)//standardvärde
        {

        }
        public override double Area()//metod som returnerar värde och skriver ut värdet efter areauträkning
        {
            double area = (radie * 2 )* pi;
            Console.WriteLine(area);
            return area;
        }
        public double _radie       { get { return radie; }     set { radie = value; }//getters och setters för att nå variblerna i main
        }
        public double _pi { get { return pi; } }
    }
}
