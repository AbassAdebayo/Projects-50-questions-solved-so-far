using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritance
{
    public class Animal
    {
        public string Name;
        protected string Type;
        
        public Animal(string name, string type)
        {

            Name = name;
            Type = type;
        }
        public virtual void MakeSound() 
        {

            Console.WriteLine(" Make sound");
        }
        
        
        
        

    }
}
