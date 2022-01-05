using System;

namespace Ass_18thOct21Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the first number");
            int firstnumber=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("the second number");
            int secondnumber=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("the third number");
            int thirdnumber=Convert.ToInt32(Console.ReadLine());


           int average = (firstnumber+secondnumber+thirdnumber)/3;
            
            Console.WriteLine($"The average of {firstnumber}, {secondnumber} and {thirdnumber} is {average}");

        }
    }
}
