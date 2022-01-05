using System;

namespace AnimalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Dog = new Animal(" Dog",  " Real Animal ");

            Human Ope = new (" Ope", " human being", " Black ");

            Console.WriteLine($" Animal name is { Dog.Name}");
            Console.WriteLine($" Animal name is { Ope.Name}");

            Dog.MakeSound();
            Ope.MakeSound();
            Ope.GetType();
            Ope.MakeSound();



        }
    }
}
