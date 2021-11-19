using System;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n!= ");
            long n = long.Parse(Console.ReadLine());

            decimal nFacto = 1;

            bool isMod = false;
            double div;
            double mod;
            int count = 0;

            do
            {
                nFacto *= n;
                n--;

            } while (n>0);

            do
            {
                div= (double)nFacto / 10;
                mod = (double)nFacto % 10;

                if (mod==0)
                {
                    count++;
                }
                else
                {
                    isMod = true;
                }

                nFacto = (decimal)div;
                
            } while (!isMod);
            
            Console.Write($"\nThe counts of zeroes in n!! is {count}");
        }
    }
}