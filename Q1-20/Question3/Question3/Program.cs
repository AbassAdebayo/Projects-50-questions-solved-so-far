using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Alpha = new Random();
            int letterUpper = Alpha.Next(65,95);

            char upperCase = (char) letterUpper;
            Console.Write($"\nThe random uppercase letter is letter {upperCase}");


        }
    }
}