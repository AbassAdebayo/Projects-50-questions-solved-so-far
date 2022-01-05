using System;

namespace Animal
{
    public class Animal
    {
        public string Name;
        public int Age;
        private string Gender;

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual string Sound()
        {
          return $"Make Sound";
          
        }

        public string PrintAnimalInfo()
        {
            return $"The animal {Name} is of {Age} month(s) old and has the sound {Sound()}";
        }
    }
}