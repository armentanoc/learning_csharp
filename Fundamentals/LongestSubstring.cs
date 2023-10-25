using System;
namespace Fundamentals
{
    public class LongestSubstring
    {
        public static void run()
        {
            Console.WriteLine("\nInforme a string que deseja analisar: ");
            string s = Console.ReadLine().ToLower();

            int n = s.Length, maxLength = 0, left = 0;

            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();

            for (int right = 0; right < n; right++)
            {
                if (charIndexMap.ContainsKey(s[right]) && charIndexMap[s[right]] >= left)
                {
                    left = charIndexMap[s[right]] + 1;
                }
                charIndexMap[s[right]] = right;
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            Console.WriteLine($"\nTamanho da maior substring sem caracteres repetidos: {maxLength}");

        }
    }
}

/*

Programming Problem: Longest Substring Without Repeating Characters

Given a string, find the length of the longest substring without repeating characters.
 
 */