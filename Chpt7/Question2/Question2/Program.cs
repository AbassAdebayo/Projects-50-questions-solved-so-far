using System;
using System.Net.Http.Json;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("enter length for array1: ");
            int lengthUser1 = int.Parse(Console.ReadLine());

            Console.Write("enter length for array2: ");
            int lengthUser2 = int.Parse(Console.ReadLine());

            int[] myArray1 = new int[lengthUser1];
            int[] myArray2 = new int[lengthUser2];

            bool isSame = false;
            int i;

            if(myArray1.Length == myArray2.Length)
            {
                for (i = 0; i < lengthUser1-1; i++)
                { 
                    Console.Write("enter array2 elements: ");
                    myArray1[i] = int.Parse(Console.ReadLine());
                    
                }
                for (int j = 0; j < lengthUser2-1; j++)
                {
                    Console.Write("enter array1 elements: ");
                    myArray1[j] = int.Parse(Console.ReadLine());
                        
                    if (myArray1[i] == myArray2[j])
                    {
                        Console.Write("The two arrays contain the same length and elements");
                        isSame = true;
                    }
                }

                
                
            }
            else
            {
                Console.Write("The two arrays contain different lengths, thus their elements do not tally");
            }
        }
    }
            
    }
