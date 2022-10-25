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
        public Trekant() : this(2,2)
        {

        }
        public override  double Area( )
        {
            double area = bas * höjd;  /// SPelar roll _höjd eller höjd?        override eller inte här? 
            Console.WriteLine(area);
            return area;
        }
        public double _bas { get { return bas; } set { bas = value; } }
        public double _höjd { get { return höjd; } set { höjd = value; } }
    }
}
