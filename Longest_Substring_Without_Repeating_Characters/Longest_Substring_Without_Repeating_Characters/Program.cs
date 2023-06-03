using System;
using System.Linq;

namespace Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            var occuredString = string.Empty;
            var currentIndex = -1;
            var maxCharCount = 1;
            var lastIndex = 0;
            while (currentIndex < s.Length-1)
            {
                currentIndex += 1;
                occuredString += s[currentIndex];
                if (occuredString.IndexOf(s[currentIndex]) == occuredString.Length - 1) continue ;
                currentIndex = lastIndex;
                lastIndex += 1;
                if (maxCharCount < occuredString.Length-1) maxCharCount = occuredString.Length-1;
                occuredString = string.Empty;
            }
            if (maxCharCount < occuredString.Length) maxCharCount = occuredString.Length;
            return maxCharCount;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Example 1:(should be 3)");
            Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));

            Console.WriteLine("Example 2:(should be 1)");
            Console.WriteLine(LengthOfLongestSubstring("bbbbb"));

            Console.WriteLine("Example 3:(should be 3)");
            Console.WriteLine(LengthOfLongestSubstring("pwwkew"));

            Console.WriteLine("Example 4:(should be 0)");
            Console.WriteLine(LengthOfLongestSubstring(""));

            Console.WriteLine("Example 5:(should be 1)");
            Console.WriteLine(LengthOfLongestSubstring(" "));
            
            Console.WriteLine("Example 6:(should be 2)");
            Console.WriteLine(LengthOfLongestSubstring("au"));
            
            Console.WriteLine("Example 7:(should be 3)");
            Console.WriteLine(LengthOfLongestSubstring("dvdf"));
        }
    }
}