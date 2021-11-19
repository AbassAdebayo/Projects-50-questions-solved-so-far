using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter student's score between '1 and 9");
            double score = double.Parse(Console.ReadLine());

            if (score>=1 && score<=3)
            {
                score *= 10;
                Console.Write($"The score is {score}");
            }
            else if (score>=4 &&score<=6)
            {
                score *= 100;
                Console.Write($"The score is {score}");
            }
            else if (score>=7 && score<=9)
            {
                score *= 1000;
                Console.Write($"The score is {score}");
            }
            else if (score==0 && score>9)
            {
                Console.Write("error score!");
            }
        }
    }
}