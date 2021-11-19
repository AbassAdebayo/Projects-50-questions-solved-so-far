using System;

namespace Question15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter hexadecimal number to be converted to decimal: ");
            string hexaValue = Console.ReadLine();

            int deciValue = Convert.ToInt32(hexaValue, 16);


            Console.Write("\nHexa value= {0}", hexaValue);
            Console.Write("\nDecimal value= {0}", deciValue);

          

        }
        
    }
}