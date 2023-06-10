using System;
using System.Linq;

namespace Longest_Common_Prefix
{
    internal class Program
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length <= 0) return string.Empty;
            var prefix = strs[0];
            while (prefix.Length > 0)
            {
                if (strs.Where(elem => elem.Length >= prefix.Length && elem.Substring(0,prefix.Length) == prefix).ToArray().Length == strs.Length)
                {
                    return prefix;
                }

                prefix = prefix.Remove(prefix.Length - 1);
            }

            return string.Empty;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Example 1:(output should be ' fl ')");
            Console.WriteLine(LongestCommonPrefix(new[] { "flowers", "flow", "flight" }));
        }
    }
}