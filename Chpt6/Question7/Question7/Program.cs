using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Note: n! must be greater than k!");
            Console.Write("n!= ");
            int nFacto = int.Parse(Console.ReadLine());

            Console.Write("k!= ");
            int kFacto = int.Parse(Console.ReadLine());

            decimal nFactorial = 1;
            decimal kFactorial = 1;

            do
            {
                nFactorial *= nFacto;
                nFacto--;

            } while (nFacto>0);
            
            do
            {
                kFactorial *= kFacto;
                kFacto--;

            } while (kFacto>0);

            decimal multFacto = nFactorial * kFactorial;
            decimal minusFacto = nFactorial-kFactorial;
            decimal divFacto = multFacto / minusFacto;
            
            Console.Write($"\nThe division of N!*K!/(N-K)!= {divFacto}");
        }
        
    }
}