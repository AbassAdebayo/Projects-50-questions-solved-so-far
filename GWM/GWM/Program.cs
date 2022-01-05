using System;
using System.Collections.Generic;
using System.Net.Security;

namespace GWM
{
    class Program
    {
        static void Main(string[] args)

        {
            int markCount = 0;

            Console.WriteLine("NASA atronaut photograph  ISSO22-t-6624 Global Warming Quiz\n");
            Console.Write("Please enter your fullname: ");
            string fullName=Console.ReadLine();
            Console.Write("Welcome to NASA atronaut photograph ISSO22-t-6624 Global Warming Quiz" + fullName + "." +
                          "\n");
            Console.Write("Using the keyboard, please submit answers by using \'ENTER\' key.\n");
            Console.Write("Please submit answers in CAPITAL letter form only.\n");
            Console.Write("Ready to begin " + fullName + "? Hit the \'ENTER\' key now...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("NASA atronaut photograph ISSO22-t-6624 Global Warming Quiz\n");
            Console.Write("Question 1: What's global warming?" +
                          "\n\nA. Global warming is the usually rapid increase in earth's average surface temperature over the past century\nB. Global warming is the usually rapid decrease in earth's average surface temperature over years\nC. It's the warming up of houses\nD. All of the above\n\nWhat is your answer " +
                          fullName + "? ");
            string userAnswer = Console.ReadLine();
            Console.Clear();
            if (userAnswer != "A" && userAnswer != "B" && userAnswer != "C" && userAnswer != "D")
            {
                Console.WriteLine("\nYou have input Invalid option- please enter a valid option.");
            }
            else if (userAnswer == "A")
            {
                Console.WriteLine("\nThat's Correct!");
                markCount++;
            }
            else
            {
                Console.Write("\nSorry, that's incorrect!  The correct answer is A");

            }

            Console.WriteLine("NASA atronaut photograph ISSO22-t-6624 Global Warming Quiz\n");
            Console.Write("Question 2: What causes global warming? " +
                          "\n\nA.The carefree of people\nB. Death of unhealthy animals\nC. A and B\nD. It's caused majorly due to greenhouse gases released by people burning fossil.\n\nWhat is your answer " +
                          fullName + "? ");
            string userAnswer2 = Console.ReadLine();
            Console.Clear();
            if (userAnswer2 != "A" && userAnswer2 != "B" && userAnswer2 != "C" && userAnswer2 != "D")
            {
                Console.Write("\nYou have input Invalid option- please enter a valid option.");
            }
            else if (userAnswer2 == "D")
            {
                Console.WriteLine("\nThat's Correct!");
                markCount++;
            }
            else
            {
                Console.WriteLine("\nSorry, that's incorrect! The correct answer is D");
            }

            Console.WriteLine("NASA atronaut photograph ISSO22-t-6624 Global Warming Quiz\n");
            Console.Write("Question 3: What's climate change? " +
                          "\n\nA.The rise of weather\nB. The rainfall\nC. The long-term manifestations of change of weather in a particular area\nD. None of the above.\n\nWhat is your answer " +
                          fullName + "? ");
            string userAnswer3 = Console.ReadLine();
            Console.Clear();
            if (userAnswer3 != "A" && userAnswer3 != "B" && userAnswer3 != "C" && userAnswer3 != "D")
            {
                Console.Write("\nYou have input Invalid option- please enter a valid option.");
            }
            else if (userAnswer3 == "C")
            {
                Console.WriteLine("\nThat's Correct!");
                markCount++;
            }
            else
            {
                Console.WriteLine("\nSorry, that's incorrect! The correct answer is C");
            }

            Console.WriteLine("NASA atronaut photograph ISSO22-t-6624 Global Warming Quiz\n");
            Console.Write("Question 4: What's a climate change ? " +
                          "\n\nA.The threats of climate change include the falling of aged\nB. The main threats of climate change stemming from rising temperature of earth's atmosphere include rising sea levels, ecosystem collapse & more frequent and severe weather\nC. The acidic rainfall\nD. A and C.\n\nWhat is your answer " +
                          fullName + "? ");
            string userAnswer4 = Console.ReadLine();
            Console.Clear();
            if (userAnswer4 != "A" && userAnswer4 != "B" && userAnswer4 != "C" && userAnswer4 != "D")
            {
                Console.Write("\nYou have input Invalid option- please enter a valid option.");
            }
            else if (userAnswer4 == "B")
            {
                Console.WriteLine("\nThat's Correct!");
                markCount++;
            }
            else
            {
                Console.WriteLine("\nSorry, that's incorrect! The correct answer is B");
            }

            Console.WriteLine("NASA atronaut photograph ISSO22-t-6624 Global Warming Quiz\n");
            Console.Write(
                "Question 5: What's does global warming have to do with severe weather, like storms, heat waves, droughts,and hurricane? " +
                "\n\nA. As the earth's atmosphere heats up, it collects, retains, and drops more water, changing weather patterns and making wet areas wetter & dry areas drier\nB. The main threats of climate change stemming from rising temperature of earth's atmosphere include rising sea levels, ecosystem collapse & more frequent and severe weather\nC. The acidic rainfall\nD. A and C.\n\nWhat is your answer " +
                fullName + "? ");
            string userAnswer5 = Console.ReadLine();
            Console.Clear();
            if (userAnswer5 != "A" && userAnswer5 != "B" && userAnswer5 != "C" && userAnswer5 != "D")
            {
                Console.Write("\nYou have input Invalid option- please enter a valid option.");
            }
            else if (userAnswer5 == "A")
            {
                Console.WriteLine("\nThat's Correct!");
                markCount++;
            }
            else
            {
                Console.WriteLine("\nSorry, that's incorrect! The correct answer is A");

            }

            if (markCount == 5)
            {
                Console.Write("Excellent");
            }
            else if (markCount == 4)
            {
                Console.Write("Very good");
            }
            else if (markCount == 3 || markCount < 4)
            {
                Console.Write(
                    "Time to brush up on your knowledge of global warming,NASA atronaut photography (www.earthobservatory");
                Console.Write("The total marks scored is " + markCount);
            }
        }
    }
}