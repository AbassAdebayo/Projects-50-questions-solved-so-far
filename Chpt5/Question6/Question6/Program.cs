using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("enter the coefficient of a:");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("enter the coefficient of b:");
            int b = int.Parse(Console.ReadLine());
            
            Console.Write("enter the coefficient of c:");
            int c = int.Parse(Console.ReadLine());

            int D = (b * b) - (4 * a * c);

            double DSqrt = Math.Sqrt(D);

            if (D > 0)
            {
                double X1 = (-b + DSqrt) / 2 * a;
                double X2 = (-b - DSqrt) / 2 * a;

                Console.Write($"\nThe real roots of quadratic equation are {X1} and {X2}");
                
            }
            else if (D==0)
            {
                double x = (-b / (2 * a));
                
                Console.Write($"\nThe root is {x}");
            }
            else
            {
                Console.Write($"\nThe discriminant is negative, thus the quadratic equation" +
                              $" has no real roots");
            }
        }
    }
}