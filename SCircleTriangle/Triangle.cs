using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCircleTriangle
{
    class Triangle
    {
        double side1, side2, side3, max, x, y;
        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double PerimeterCalculator()
        {
            return side1 + side2 + side3;
        }

        public double Perimeter
        {
            get
            {
                return this.PerimeterCalculator();
            }
        }

        public double AreaCalculator()
        {
            return (side1 + side2 + side3) / 2;
        }

        public double Area
        {
            get
            {
                return this.AreaCalculator();
            }
        }

        public string RightTriangle()
        {
            Max();
            if (max == x + y)
            {
                return "Треугольник прямоугольный";
            }
            else
            {
                return "";
            }
        }

        public double Max()
        {
            max = 0;
            if (side1 >= side2 && side1 >= side3)
            {
                max = side1; x = side2; y = side3;
            }
            else
            {
                if (side2 >= side1 && side2 >= side3)
                {
                    max = side2; x = side1; y = side3;
                }
                else
                {
                    max = side3; x = side1; y = side2;
                }
            }
            return max;
        }
    }
}