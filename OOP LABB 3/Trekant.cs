using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LABB_3
{
    class Trekant:Geometri
    {
        public double bas;
        public double höjd;
        public Trekant(double _bas, double _höjd)
        {
            bas = _bas;
            höjd = _höjd;
        }
        public Trekant() : this(5,4)//standardvärden
        {
        }
        public override double Area( )
        {
            double area = bas * höjd; 
            Console.WriteLine(area);
            return area;
        }
    }
}
