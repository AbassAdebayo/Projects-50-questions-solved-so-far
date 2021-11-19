using System;

namespace Question13
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double power = 0;
            double x = 0;
            double div = 0;
            int mod = 0;

            Console.Write("enter a number in binary: ");
            int binary = int.Parse(Console.ReadLine());
            for (;;)
            {
                div = binary / 10;
                mod = binary % 10;
                x = Math.Pow(2, power);
                sum += mod * x;
                binary = (int)div;
                power++;

                if (div==0)
                {
                    break;
                }
            }
            Console.Write($"The conversion of binary number to decimal is {sum}");
        }

       
    }
}