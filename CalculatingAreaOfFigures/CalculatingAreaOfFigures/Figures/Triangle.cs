using System;

namespace CalculatingAreaOfFigures
{
  public class Triangle:IFigureArea
    {
        double a, b, c; //-- стороны треугольника
       
        public Triangle( double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double Area()
        {
            var p = (a + b + c) / 2; //-- полупериметр треугольника

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); //-- формула площади треугольника по трем сторонам
        }
    }
}
