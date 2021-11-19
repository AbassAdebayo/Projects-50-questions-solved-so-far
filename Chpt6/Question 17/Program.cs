using System;

namespace Question_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number ");
            int num2 = int.Parse(Console.ReadLine());

            int minimum = Math.Min(num1 , num2);
            int gcd = 0;
            int lcm = 0;
            
            for(int i = 1; i <= minimum; i++)
            {
                if(num1%i == 0 && num2%i == 0)
                {
                    gcd = i;
                }
            }
            Console.WriteLine($"The greatest common divisor between the two factors is {gcd}");
            for(int k = 1; k > 0; k++  )
            {
                if(k%num1 == 0 && k%num2 == 0)
                {
                    lcm = k;
                    break;
                }
            }
            Console.WriteLine($"The lowest common factor between the two numbers is {lcm}");
        }
    }
}
