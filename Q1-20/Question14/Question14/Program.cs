using System;

namespace Question14
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrect = true;

            Console.Write("\n(Computer-Assisted Instruction) The use of computers in education" +
                          " is referred to as computer-assisted instruction (CAI).");
            
            while (isCorrect)
            {
                Random mult = new Random();
                int num1 = mult.Next(1, 6);
                
                Random mult2 = new Random();
                int num2 = mult2.Next(2, 5);

                Console.Write($"\nHow much is {num1} * {num2}? ");
                int userAnswer = int.Parse(Console.ReadLine());

                if (userAnswer==num1*num2)
                {
                    Console.Write("\nVery good!");
                    
                    Console.Write("Do you want to try another multiplication? Enter 'y' key to continue " +
                                  "and 'n' key to terminate: ");
                    string reply = Console.ReadLine();
                    
                    
                    if (reply.ToUpper()=="N")
                    {
                        isCorrect = false;
                        
                        
                    }
                    else if (reply.ToUpper()== "Y")
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write("unknown input, stopping.....");
                    }
                   
                }
                else if (userAnswer!=num1*num2)
                { 
                    Console.Write("\nNo, Please try again");

                }
            }
        }
    }
}