using System;

namespace Class_Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Adebayo","Abass",85.5);
            Worker worker1 = new Worker("Adeoyin","Yussuf",150000,50);
            
            Console.Write(worker1.PrintWage(150000,50));
            
        }
    }
}