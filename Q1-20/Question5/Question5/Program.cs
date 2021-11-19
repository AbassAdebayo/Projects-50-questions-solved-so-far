using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
           decimal numFacto = 1;
            int i;
            
            
            for (i = 1; i <=1; i++)
            {
                numFacto *= i;
                
            }
            Console.Write($"\n1!=   {numFacto}");
            
            
            for (i = 1; i <=2; i++)
            {
                numFacto *= i;
                
            }
            Console.Write($"\n2!=   {numFacto}");
            
            
            for (i = 1; i <=3; i++)
            {
                numFacto *= i;
                
            }
            Console.Write($"\n3!=   {numFacto}");
            
            
            for (i = 1; i <=4; i++)
            {
                numFacto *= i;
                
            }
            Console.Write($"\n4!=   {numFacto}");
            
            
            for (i = 1; i <=5; i++)
            {
                numFacto *= i;
                
            }
            Console.Write($"\n5!=   {numFacto}");
            
            for (i = 1; i <=20; i++)
            {
                numFacto *= i;
                
            }
            Console.Write($"\n20!=  {numFacto}");
        }
    }
}