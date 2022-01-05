using System;

namespace Ass_18thOct21Sum
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("enter the first number");
            int firstnumber= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number");
            int secondnumber= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the third number");
            int thirdnumber= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the fourth number");
            int fourthnumber= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the fifth number");
            int fifthnumber=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the sixth number");
            int sixthnumber=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the seventh number");
            int seventhnumber=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the eighth number");
            int eightnumber=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the ninth number");
            int ninthnumber=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the tenth number");
            int tenthnumber=Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine($"the sum of the ten  numbers is  {firstnumber+secondnumber+thirdnumber+fourthnumber+fifthnumber+sixthnumber+seventhnumber+eightnumber+ninthnumber+tenthnumber}");
        }
    }
}
