using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number from 0-9");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case (0):
                {
                    Console.Write("Zero");
                    break;
                }
                case (1):
                {
                    Console.Write("One");
                    break;
                }
                case(2):
                {
                    Console.Write("Two");
                    break;
                }
                case(3):
                {
                    Console.Write("Three");
                    break;
                }
                case (4):
                {
                    Console.Write("Four");
                    break;
                }
                case (5):
                {
                    Console.Write("Five");
                    break;
                }
                case (6):
                {
                    Console.Write("Six");
                    break;
                }
                case (7):
                {
                    Console.Write("Seven");
                    break;
                }
                case (8):
                {
                    Console.Write("Eight");
                    break;
                }
                case (9):
                {
                    Console.Write("Nine");
                    break;
                }
                default:
                {
                    Console.Write("Invalid entry! enter a  number between the range of 0-9");
                    break;
                }
            }
        }
    }
}