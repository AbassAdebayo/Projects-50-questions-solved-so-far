using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritance
{
    public class Human : Animal
    {
        string Race;
        public Human( string name, string type, string race) : base(name, type)
        {
            Race = race;   
        }
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("This is human sound");
        }
    }
}
