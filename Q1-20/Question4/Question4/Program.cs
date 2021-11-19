using System;
using System.Collections.Generic;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = {3, 3, 4, 4, 6, 7, 8, 9};
            int[] input2 = {1, 2, 3, 4, 5, 6, 10, 11, 12, 13, 14};
            int [] emptyArray= new int[input1.Length+input2.Length];
            Array.Copy(input1,emptyArray,input1.Length);
            Array.Copy(input2,emptyArray,input2.Length);
            Array.Sort(emptyArray);
            var sorted = new List <int>();

            foreach (var item in emptyArray)
            {
                if (item != 0)
                {
                    sorted.Add(item);
                }
                
                
            }
            Console.Write($"{String.Join(',', sorted)}");
            

            
            

            
        }
    }
}