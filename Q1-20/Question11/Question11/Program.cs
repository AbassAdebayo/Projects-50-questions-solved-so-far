using System;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("e!= ");
            int e = int.Parse(Console.ReadLine());
            
            Console.Write("x= ");
            int x = int.Parse(Console.ReadLine());
            
            decimal eFactorial = 1;
            double sum = 1;
            double power;

            for (int i = 1; i<=e; i++)
            {
                eFactorial *= i;
                power = Math.Pow(x, i);

                sum +=power/e;
            }
            Console.Write($"\nThe sum of factorial is {sum}");
        }
    }
}