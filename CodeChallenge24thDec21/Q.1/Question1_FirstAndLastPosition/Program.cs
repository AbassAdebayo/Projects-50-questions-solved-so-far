using System;

namespace Question1_FirstAndLastPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumbers = { 5, 7, 7, 8, 8, 10};
            int y = 9;
            
            findFirstAndLast(arrNumbers, y);
        }
        
        
        
             public static void findFirstAndLast(int[] arr, int a)
            {
                
                int first = -1, last = -1;
         
                for (int i = 0; i < arr.Length; i++) 
                {
                    if (a != arr[i])
                        continue;
                    if (first == -1)
                        first = i;
                    last = i;
                }
                if (first != -1) 
                {
                    Console.WriteLine($"Output: [{first}, {last}]");
                   
                }
                else
                    Console.Write("Output: [-1,-1]");
            }
    }
}