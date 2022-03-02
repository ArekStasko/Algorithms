using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = MinIndexValue(new int[] { 0, 534, 188, 237, 10, 576, 13, 1234, 1, 677 });
            Console.WriteLine(result);
        }

        public static bool IsTwoDigit(int num)
        {
            if (num > 9 && num < 99) return true;
            return false;
        }

        public static int MinIndexValue(int[] nums)
        {
            int min = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (!IsTwoDigit(nums[min])) min = i;
                if (nums[i] < nums[min] && IsTwoDigit(nums[i])) min = i;
            }

            if (IsTwoDigit(nums[min])) return min;
            return -1;
        }

    }
}