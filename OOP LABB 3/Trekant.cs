using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LABB_3
{
    class Trekant:Geometri
    {
        protected double bas;
        protected double höjd;
        public Trekant(double _bas, double _höjd)
        {
            bas = _bas;
            höjd = _höjd;
        }
        public Trekant() : this(2,5)
        {

        }
        public override double Area(double area )
        {
            area = bas * höjd;
            return area;
        }
    }
}
