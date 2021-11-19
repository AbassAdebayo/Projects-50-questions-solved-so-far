using System;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            long num, i;
            
            Console.Write("enter number to be converted: ");
            num = int.Parse(Console.ReadLine());

            long deci;

            for (i = 0; num > 0; i++)
            {
                deci = num%2;
                num = num / 2;
                Console.Write(deci);
            }

           

           

        }
    }
}