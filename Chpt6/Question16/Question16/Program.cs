using System;

namespace Question16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter N integer: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            Random randomOrder = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randomOrder.Next(1, numbers.Length);
            }
            
            foreach (var item in numbers)
            {
                Console.Write(item);
                Console.Write(item.ToString(" "));
            }
            
    
            

        }
    }
}