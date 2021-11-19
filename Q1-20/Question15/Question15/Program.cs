using System;

namespace Question15
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrect = true;

            while (isCorrect)
            {
                Random mult = new Random();
                int num1 = mult.Next(1, 12);

                Random mult2 = new Random();
                int num2 = mult2.Next(1, 12);
                

                Console.Write($"\nHow much is {num1} * {num2}? ");
                int userAnswer = int.Parse(Console.ReadLine());

                int response = mult.Next(1, 4);

                if ((userAnswer== num1*num2) && (userAnswer==response))
                    
                {

                    switch (response)
                    {
                        case 1:
                        {
                            Console.Write("Excellent!");
                            break;
                            ;
                        }
                        case 2:
                        {
                            Console.Write("Very good!");
                            break;
                        }
                        case 3:
                        {
                            Console.Write("Nice work!");
                            break;
                        }
                        case 4:
                        {
                            Console.Write("Keep up the good work!");
                            break;
                        }
                            
                    }
                    

                    
                }
                else
                {
                    switch (response)
                    {
                        case 1:
                        {
                            Console.Write("No. Please try again");
                            break;
                        }
                        case 2:
                        {
                            Console.Write("Wrong. Try once more.");
                            break;
                        }
                        case 3:
                        {
                            Console.Write("Don't give up!");
                            break;
                        }
                        case 4:
                        {
                            Console.Write("No. keep ");
                            break;
                        }
                            
                            
                           
                        
                    }
                    
                }
                

                

            }

            
        }
    }
}