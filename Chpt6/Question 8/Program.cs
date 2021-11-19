using System;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            int multiply = number * 2;
            int add = number + 1;
            int factorialMultiply = 1; 
            int factorialAdd = 1; 
            int factorialNumber = 1; 

            for(int i = 1; i <= number; i++)
            {
                factorialNumber*= i;
            }
            for(int i = 1; i <= multiply; i++)
            {
                factorialMultiply*= i;
            }
            for(int i = 1; i <= add; i++)
            {
                factorialAdd*= i;
            }
            Console.WriteLine(factorialAdd);
            Console.WriteLine(factorialMultiply);
            Console.WriteLine(factorialNumber);

            int result = (factorialAdd) * factorialNumber;
            int total = factorialMultiply / result;
            Console.WriteLine(total);
        }
    }
}
