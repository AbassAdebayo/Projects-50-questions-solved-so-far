using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number");
            int num3 = int.Parse(Console.ReadLine());

            if(1 > 0 )
            {
                if(num1 >= num3 )
                {
                    num1 = num1 + num3;
                    num3 = num1 - num3;
                    num1 = num1 - num3;
                }
                if(num2 >= num3)
                {
                    num2 = num2 + num3;
                    num3 = num2 - num3;
                    num2 = num2 - num3;
                }
                if(num1 >= num2)
                {
                    num1 = num1 + num2;
                    num2 = num1 - num2;
                    num1 = num1 - num2;
                }

            }
            Console.WriteLine($"The biggest number is {num3}");
            
        }
        

    }
}
