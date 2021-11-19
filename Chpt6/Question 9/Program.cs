using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            double number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double number2 = int.Parse(Console.ReadLine());
            double sum = 1;
            double factorial = 1;
            for(int i = 1; i <= number ; i++)
            {
                factorial *= i;
                double power = Math.Pow(number2 , i);
                sum += factorial/power;

            }
            Console.WriteLine(sum);
        }
    }
}
