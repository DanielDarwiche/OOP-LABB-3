using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LABB_3
{
    class Rektangel:Geometri
    {
        protected double bredd;
        protected double höjd;
        public Rektangel(double _bredd, double _höjd)
        {
            bredd = _bredd;
            höjd = _höjd;
        }
        public Rektangel() : this(2,5) {         }

        public  double Area(double bredd, double höjd )
        {
            double area = bredd * höjd;
            return area;
        }
        public double _bredd { get { return bredd; } set { bredd = value; } }
        public double _höjd { get { return höjd; } set { höjd = value; } }
    }
}
