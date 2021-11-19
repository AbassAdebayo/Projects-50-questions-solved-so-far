using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            int n1 = 0;
            int n2 = 1;
            int n3;
            string j = String.Empty;
            for (int i = 0; i < n; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;

                Console.Write(n3+",");





            }
        }
    }
}