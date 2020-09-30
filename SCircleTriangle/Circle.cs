using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCircleTriangle
{
    public class Circle
    {
        double radius;
        const double pi = 3.14;

        public Circle(double r)
        {
            this.radius = r;
        }

        public double AreaCalculator()
        {
            return pi * (radius * radius);
        }

        public double Area
        {
            get
            {
                return this.AreaCalculator();
            }
        }
    }
}
