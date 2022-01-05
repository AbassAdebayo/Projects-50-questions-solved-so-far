using System;

namespace Animal
{
    public class Dog:Animal
    {
        public Dog(string name, int age): base(name,age)
        {
             
        }

        public override string Sound()
        {
            return $"Bark";
        }
    }
}