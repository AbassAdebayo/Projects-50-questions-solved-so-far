using System;

namespace Question3_TwoSumTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new[] {3, 2, 4};

            int[] totalResultOfTwoSum= TwoSum(arrayNumbers, 6);
            
            Console.WriteLine($"Input: [{string.Join(", ", arrayNumbers)}]");
            
            Console.WriteLine($"Output: [{string.Join(", ", totalResultOfTwoSum)}]");
            

            Console.WriteLine();
        }

        private static int[] TwoSum(int[] numbers, int target)
        {

            if (numbers == null || numbers.Length < 2)
            {
                return Array.Empty<int>();
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                        return new int[]
                        {
                            i,
                            j
                        };
                }
            }

            return Array.Empty<int>();
        }


    }
}
