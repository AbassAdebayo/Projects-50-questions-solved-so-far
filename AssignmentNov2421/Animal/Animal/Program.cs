using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            var Dog = new Dog("Bingo", 9);
            var Frog = new Frog("kroor", 2);
            var Cat = new Cat("Pizzy", 7);
            var Kitten = new Kitten("Spurry", 6);
            var Tomcat = new Tomcat("Debby", 8);


            Animal[] Animals = new Animal[] {Dog, Frog, Cat, Kitten, Tomcat};

            foreach (var item in Animals)
            {
                Console.WriteLine(item.PrintAnimalInfo());
            }
        }
    }
}