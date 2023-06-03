using System;
using System.Collections;
using System.Linq;

namespace Two_Sum
{
    internal class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var auxNums = nums;
            while (auxNums.Length > 0)
            {
                if (((IList)auxNums.Skip(1).ToArray()).Contains(target - auxNums[0]))
                {
                    var possibleNumber = auxNums.SkipWhile(id => id != target - auxNums[0]);
                    return new int[]
                    {
                        Array.IndexOf(nums, auxNums[0]),
                        Array.LastIndexOf(nums, possibleNumber.FirstOrDefault()),
                    };
                }

                auxNums = auxNums.Skip(1).ToArray();
            }

            return new int[] { };
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Example 1:");
            Console.WriteLine(string.Join(",", TwoSum(new int[] { 2,7,11,15 }, 9)));
            
            Console.WriteLine("Example 2:");
            Console.WriteLine(string.Join(",", TwoSum(new int[] { 3,2,4 }, 6)));
            
            Console.WriteLine("Example 3:");
            Console.WriteLine(string.Join(",", TwoSum(new int[] { 3,3 }, 6)));
            
            Console.WriteLine("Example 4:");
            Console.WriteLine(string.Join(",", TwoSum(new int[] { 0,4,3,0 }, 0)));
            
            Console.WriteLine("Example 5:");
            Console.WriteLine(string.Join(",", TwoSum(new int[] { -1,-2,-3,-4,-5 }, -8)));
        }
    }
}