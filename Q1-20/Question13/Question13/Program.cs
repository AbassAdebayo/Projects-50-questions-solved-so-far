using System;

namespace Question13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter four (4) digits number: ");
            int num = int.Parse(Console.ReadLine());

            int digit1 = num / 1000;
            int digit2 = (num / 100) % 10;
            int digit3 = (num/10) % 10;
            int digit4 = num % 10;
            
            Console.Write($"{digit4}{digit3}{digit2}{digit1}");
        }
    }
}