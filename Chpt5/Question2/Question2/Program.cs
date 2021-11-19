using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("enter third number: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 < 0 && num2 < 0 && num3 > 0)
            {
                Console.Write("\nThe product of the three integers is positive (+)");
            }
            else if (num1 > 0 && num2 > 0 && num3 < 0)
            {
                Console.Write("\nThe product of the three integers is negative (-)");
            }
            else if (num1 > 0 && num2 < 0 && num3 > 0)
            {
                Console.Write("\nThe product of the three integers is negative (-)");
            }
            else if (num1 > 0 && num2 > 0 && num3 > 0)
            {
                Console.Write("\nThe product of the three integers is positive (+)");
            }
            else if (num1<0&&num2<0&&num3<0)
            {
                Console.Write("\nThe product of the three integers is negative (-)");
            }
            else if (num1<0&&num2>0&&num3>0)
            {
                Console.Write("\nThe product of the three integers is negative (-)");
            }
            else if (num1<0&&num2>0&&num3<0)
            {
                Console.Write("\nThe product of the three integers is positive (+)");
            }
            else if (num1>0&&num2<0&&num3<0)
            {
                Console.Write("\nThe product of the three integers is positive (+)");
            }
            else if (num1 == 0 && num2 > 0 && num3 > 0 || num2 == 0 && num1 < 0 && num3 < 0 ||
                     num3 == 0 && num2 > 0 && num1 > 0)
            {
                Console.Write("\nThe product of the three integers is positive (+)");
            }
        }
    }
}