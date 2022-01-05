using System;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] scores = new int[3, 2];
            string[] students = new string[10];
            string[] subjects = new string[2] { "Math", "Eng"};
            int[] totalScores = new int[10];
           
            int totalSum = 0, max = 0, min = 0;
            string best = "", least = "";
            for (int i = 0; i < scores.GetLength(0); i++)
            {
                Console.Write("Enter student name: ");
                students[i] = Console.ReadLine();
                int sum = 0;
                for (int j = 0; j < scores.GetLength(1); j++)
                {
                    Console.Write($"Enter score for {students[i]} in {subjects[j]}: ");
                    scores[i,j] = (int.Parse(Console.ReadLine()) + 5);
                    sum += scores[i, j];
                }
                if(i == 0) { min = sum; }
                totalScores[i] = sum;
                totalSum += sum;
                if(sum > max) 
                { 
                    max = sum;
                    best = students[i];
                }
                if(sum < min) 
                { 
                    min = sum;
                    least = students[i];
                }
                Console.WriteLine();//new line at each row  
            }

            for (int x = 0; x < scores.GetLength(0); x++)
            {
                for (int y = 0; y < scores.GetLength(1); y++)
                {           

                    Console.WriteLine($"{students[x]} scored {scores[x,y]} in {subjects[y]} ");
                }
                Console.WriteLine($"Total score for {students[x]} is {totalScores[x]} and Average score is: {totalScores[x] / 2D}");
                Console.WriteLine();//new line at each row  
            }
            
            Console.WriteLine();
            Console.WriteLine($"Total average score is: {totalSum/10D}");
            Console.WriteLine($"Total best student is: {best}");
            Console.WriteLine($"Total least student is: {least}");















      






























        }
    }
}
