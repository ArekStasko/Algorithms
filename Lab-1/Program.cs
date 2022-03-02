using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = MinIndexValue(new int[] { 0, 534, 188, 237, 10, 576, 13, 1234, 1, 677 });
            Console.WriteLine(result);

            int getSumResult = GetSum(new int[] { 1, 234, 2345, 2 }, 3);
            Console.WriteLine(getSumResult);
        }

        public static bool IsTwoDigit(int num)
        {
            if (num > 9 && num < 99) return true;
            return false;
        }

        public static int MinIndexValue(int[] nums)
        {
            if (nums.Length == 0) return -1;

            int min = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (!IsTwoDigit(nums[min])) min = i;
                if (nums[i] < nums[min] && IsTwoDigit(nums[i])) min = i;
            }

            if (IsTwoDigit(nums[min])) return min;
            return -1;
        }


        public static int GetSum(int[] nums, int k)
        {
            int sum = 0;
            foreach (var num in nums) sum += num;
            int average = sum / nums.Length;

            sum = 0;
            foreach(int num in nums)
            {
                if (num < average) sum += num;
            }

            return sum;
        }
    }
}