using System;

namespace Atcoder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var values = Console.ReadLine().Split(' ');
            var length = int.Parse(values[0]);
            var left = int.Parse(values[1]);
            var right = int.Parse(values[2]);
            
            int[] nums = new int[length];
            for (int i = 0; i < length; i++) {
                nums[i] = i + 1;
            }
            
            for (int i = left - 1, j = right - 1; i < j; i++, j--) {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
            
            foreach (int num in nums) {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}