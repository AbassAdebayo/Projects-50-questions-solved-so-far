using System;

namespace GRADE
{
    internal class Program
    {
        public static void Main(string[] args)
        {
             Console.WriteLine("enter the score");
             Double score = Convert.ToDouble(Console.ReadLine());
             if (score>=70)
             {
                 Console.WriteLine("the grade is A");
             }
             else if (score>=60)
            {
                Console.WriteLine("the grade is B");
            }

             else if(score>=50)
             {
                 Console.WriteLine("the grade is C");
             }

            else if (score>=40)
             {
                 Console.WriteLine("the grade is D");
             }
             else

             {
                 Console.WriteLine("the grade is F");
             }
        }
    }
}