using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n!= ");
            decimal nFacto = decimal.Parse(Console.ReadLine());

            decimal nFactorial = 1;

            while (nFacto>0)
            {
                nFactorial *= nFacto;
                nFacto--;
            }
            Console.Write("n!= "+nFactorial);
        }
    }
}