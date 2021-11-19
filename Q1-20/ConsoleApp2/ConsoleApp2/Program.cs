using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random lotterNumbers = new Random();
            int lottery = lotterNumbers.Next(1000);
            Console.Write(lottery);
            
            Console.Write("\nenter three(3) lottery digits: ");
            
            int guess = int.Parse(Console.ReadLine());
            

            int lotteryDigit1 = lottery % 100;
            int lotteryDigit2 = (lottery % 100) / 10;
            int lotteryDigit3 = lottery / 10;

            int guessDigit1 = guess % 100;
            int guessDigit2 = (guess % 100) / 10;
            int guessDigit3 = guess / 100;

            if (guess==lottery)
            {
                Console.Write("\nThe award is $10,000 prize");
            }
            else if (guessDigit2==lotteryDigit1 && guessDigit1== lotteryDigit2 && guessDigit3==lotteryDigit3)
            {
                Console.Write("\nThe award is $3,000 prize");
            }
            else if (guessDigit1==lotteryDigit1 || guessDigit1==lotteryDigit2 || guessDigit1==lotteryDigit3
            || guessDigit2==lotteryDigit1 || guessDigit2==lotteryDigit2 || guessDigit2==lotteryDigit3 || 
            guessDigit3==lotteryDigit1 || guessDigit3==lotteryDigit2 || guessDigit3==lotteryDigit3)
            {
                Console.Write("\nThe award is $1,000 prize");
            }
            else
            {
                Console.Write("No match! try come back later....");
            }
        }
    }
}