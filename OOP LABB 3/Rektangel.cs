using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LABB_3
{
    class Rektangel:Geometri
    {
        public double bredd;
        public double höjd;
        public Rektangel(double _bredd, double _höjd) 
        {
            bredd = _bredd;
            höjd = _höjd;
        }
        public Rektangel() : this(2,3) { }//standardvärden
        public override double Area()//metod som räknar ut och skriver ut arean
        {
            double area = bredd * höjd;
            Console.WriteLine(area);
            return area;
        }
    }
}
