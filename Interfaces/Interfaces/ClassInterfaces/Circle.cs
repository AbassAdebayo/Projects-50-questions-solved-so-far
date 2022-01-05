using System;

namespace Interfaces
{
    public class Circle: IShape
    {
        public string Name { set; get; }
        public string GetName()
        {
            return "Circle";
        }
        
        public double GetArea()
        {
            double  area = Math.PI;
            return area;
        }
        public int Area { get; set; }

        public double GetSquare()
        {
           
            double square = Math.Pow(length, 2);
            return square;
        }
        public int length { get; set; }
        
        public string squareName { get; set; }

        public string GetSquareName()
        {
            return "Square";
        }
        
        public Circle(int radius)
        {
            Radius = radius;
        }

        protected Circle()
        {
            throw new NotImplementedException();
        }

        public int Radius { set; get; }

        public double CircleCalc()
        {
            return GetArea() * Radius;
        }
        
      
        
        
    }
}