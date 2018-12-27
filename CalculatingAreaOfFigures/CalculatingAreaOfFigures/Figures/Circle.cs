using System;

namespace CalculatingAreaOfFigures
{
   public class Circle:IFigureArea
    {
        double r; //-- радиус круга
        public Circle(double r)
        {
            this.r = r;
        }
        public double Area()
        {
            return Math.PI * Math.Pow(r, 2); //-- формула пл-ди круга
        }
    }
}
