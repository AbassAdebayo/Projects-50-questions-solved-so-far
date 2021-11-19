using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("e!= ");
            int e = int.Parse(Console.ReadLine());
            
            
            decimal eFactorial = 1;
            decimal sum = 1;
            

            for (int i = 1; i<=e; i++)
            {
                eFactorial *= i;

                sum +=1/e;
            }
            Console.Write($"\nThe sum of factorial e is {sum}");
        }
    }
}