using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the year (e.g 2012): ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("enter the day of the month(1-31): ");
            int q = int.Parse(Console.ReadLine());

            Console.Write("enter the month(1-12): ");
            int m = int.Parse(Console.ReadLine());

            int j = year / 100;
            int k = year % 100;


            if (m == 1)
            {
                m = 13;
                year += 1;

            }

            if (m == 2)
            {
                m = 14;
                year += 1;
            }

            int a1 = (26*(m + 1) / 10);
            int a2 = (k / 4);
            int a3 = (j / 4);
            int a4=(5 * j);


            int h = (q +a1 + k + a2 + a3 + a4) % 7;

            switch (h)
            {
                case (0):
                {
                    Console.Write("Saturday");
                    break;
                }
                case (1):
                {
                    Console.Write("Sunday");
                    break;
                }
                case (2):
                {
                    Console.Write("Monday");
                    break;
                }
                case (3):
                {
                    Console.Write("Tuesday");
                    break;
                }
                case (4):
                {
                    Console.Write("Wednesday");
                    break;
                }
                case (5):
                {
                    Console.Write("Thursday");
                    break;
                }
                case (6):
                {
                    Console.Write("Friday");
                    break;
                }
                
                
            }
            Console.Write($", {h} {q} {m} {year}");
        }
    }
}

