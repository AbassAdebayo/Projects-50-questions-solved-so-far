using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle(10);
            
            
            

            Console.WriteLine($"The area of a {myCircle.GetName()} is {myCircle.CircleCalc()}");
            Console.WriteLine();
        }
    }
    
    
}