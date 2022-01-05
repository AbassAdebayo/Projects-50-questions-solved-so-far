using System;

namespace Question2_LongestPalindromicSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = "cbbd";
            Console.Write($"\nLength is: {LongestPalindromic(input)}");
        }
        static void printSubString(String s, int low, int high)
        {
            for (int i = low; i <= high; ++i)
                Console.Write(s[i]);
        }

        static int LongestPalindromic(String palString)
        {

            int maxLength = 1, initialize = 0;

            for (int i = 0; i < palString.Length; i++)
            {
                for (int j = i; j < palString.Length; j++)
                {
                    int check = 1;

                    for (int k = 0; k < (j - i + 1) / 2; k++)
                        if (palString[i + k] != palString[j - k])
                            check = 0;


                    if (check != 0 && (j - i + 1) > maxLength)
                    {
                        initialize = i;
                        maxLength = j - i + 1;
                    }
                }
            }
            Console.Write("longest palindrome subString is: ");
            printSubString(palString, initialize, initialize + maxLength - 1);
            
            return maxLength;
            
        }
        
        
    }
}
