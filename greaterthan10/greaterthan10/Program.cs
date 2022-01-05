using System;

namespace greaterthan10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num==10)
            {
                Console.WriteLine("the number is 10");
            }
            else if (num == 20)
            {
                Console.WriteLine("the number is 20");
            }

            else if (num==30)
            {
                Console.WriteLine("the number is 30");
            }
            else if (num==40)
            {
                Console.WriteLine("the number is 40");
            }
            else if (num==50)
            {
                Console.WriteLine("the number is 50");
            }
            else
            
            {
                Console.WriteLine("invalid");
            }
            




        }
        
    }
}