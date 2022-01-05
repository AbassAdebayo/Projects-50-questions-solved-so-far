using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface Person<T>
    {
        public List<T> GetNames();
    }

    public class People : Person<string>
    {
        public List<string> GetNames()
        {
            return new List<string>
            {
                "Ade",
                "Bolu",
                "Shade",
                "Bimpe",
            };
        }
    }
        
        
}
