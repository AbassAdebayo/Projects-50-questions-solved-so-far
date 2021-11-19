using System;
using System.Diagnostics.CodeAnalysis;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5]; ;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"enter input {i+1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
                
                
            }
            double avg = Mean(numbers);
            Console.Write($"The average of {numbers.Length} is {avg}");
        }


        public static int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static double Mean(int [] numbers)
        {
            int sum = Sum(numbers);
            double avg =  (double)sum / numbers.Length;

            return avg;
        }
        
    }
}