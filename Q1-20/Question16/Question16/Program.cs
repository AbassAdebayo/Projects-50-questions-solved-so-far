using System;

namespace Question16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nenter the numbers of students: ");
            int studentNumber = int.Parse(Console.ReadLine());

            int[] studentScore = new int[studentNumber];
            string[] studentName = new string[studentNumber];
            int i;

            int highestScore = 0;   
            int maxIndex = 0;

            for (i = 0; i < studentScore.Length; i++)
            {
                Console.Write($"enter Student Name{i + 1}: ");
                studentName[i] = Console.ReadLine();

                Console.Write($"enter score{i + 1}: ");
                studentScore[i] = int.Parse(Console.ReadLine());


                if (studentScore[i] > highestScore)
                {
                    highestScore = studentScore[i];
                    maxIndex = i;
                }
            }
            Console.Write($"\n{studentName[maxIndex]} has the highest score of {studentScore[maxIndex]}");
        }

        
    }
}
