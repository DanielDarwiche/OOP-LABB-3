using System;
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
        public Cirkel():this(12)
        {

        }
        public override double Area(double area )
        {
            area = (radie * 2 )* pi;
            return area;
        }
    }
}
