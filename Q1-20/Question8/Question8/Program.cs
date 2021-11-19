using System;
using System.Collections.Generic;
using System.Reflection;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] duplicate = {3, 6, 4, 3, 6, 4, 8, 7, 8, 7};
            var arr = new List<int>();


            foreach (var item in duplicate)
            {
                if (!arr.Contains(item))
                {
                    arr.Add(item);
                    

                    
                }


            }
            Console.Write($"{String.Join(',', arr)}");
        }
    }
}