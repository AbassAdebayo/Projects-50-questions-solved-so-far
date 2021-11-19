using System;

namespace Question14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter decimal number to be converted to hexadecimal: ");
            int numDecimal = int.Parse(Console.ReadLine());

            string hexa = Convert.ToString(numDecimal, 16).ToUpper();
            
            Console.Write($"\nThe conversion of decimal to hexadecimal is {hexa}");
        }
    }
}

