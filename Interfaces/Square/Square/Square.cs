using System;

namespace Square
{
    public class Square: IShape
    {
        public double SquareCalc { get; set; }

        public double GetSquare()
        {
            return lengthPow;
        }
        
        public double Length(double length)
        {
            lengthPow = length * length;
            return lengthPow;
        }
        public double lengthPow { get; set; }
        
        public string squareName { get; set; }

        public string GetSquareName()
        {
            return "Square";
        }

    }
}