using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int med = 0;
            int min = 0;

            Console.Write("enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("enter third number: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num2 > num3)
            {
                max = num1;
                med = num2;
                min = num3;

            }

            if (num2 > num1 && num1 > num3)
            {
                max = num2;
                med = num1;
                min = num3;
            }

            if (num3 > num2 && num2 > num1)
            {
                max = num3;
                med = num2;
                min = num1;
            }

            if (num1 > num3 && num3 > num2)
            {
                max = num1;
                med = num3;
                min = num2;
            }

            if (num1 < num3 && num3 < num2)
            {
                min = num1;
                med = num3;
                max = num2;

            }

            if (num1 < num3 && num2 < num1)
            {
                max = num3;
                med = num1;
                min = num2;
            }

            Console.Write($"The biggest of the three integers is {max},{med},{min}");
        }
    }
}