using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.SCircleTriangle;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите превую сторону прямоугольника");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите вторую сторону прямоугольника");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите вторую сторону прямоугольника");
            double side3 = Convert.ToDouble(Console.ReadLine());

            Triangle triangle = new Triangle(side1, side2, side3);
            Console.WriteLine("Perimeter = {0}, Area= {1}", triangle.Perimeter());
        }
    }
}
