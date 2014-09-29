using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        private double radius;

        public double _radius
        {
            set { radius = value; }
            get { return radius; }
        }

        public double Diameter()
        {
            return 2 * _radius;
        }
        public double Perimeter()
         {
             return 2 * Math.PI * _radius;
         }
        public double Area()
         {
             return Math.PI * _radius * _radius;
         }
    }
}
