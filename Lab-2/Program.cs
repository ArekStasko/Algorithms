using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(silnia(6));

            //should return 21
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
            int recursionSumResult = RecursionSum(nums);
            Console.WriteLine(recursionSumResult);

            //should return 3
            string[] elements = new string[] { "ark", "brk", "gdk", "ark", "ark" };
            int findRepeatingElementResult = FindRepeatingElement(elements, "ark");
            Console.WriteLine(findRepeatingElementResult);

            //should return Fizz
            Console.WriteLine(FizzBuzz(45)); 
            //should return Buzz
            Console.WriteLine(FizzBuzz(45));
            //should return FizzBuzz
            Console.WriteLine(FizzBuzz(45));
        }

        public static int silnia(int num)
        {
            if (num == 0) return 1;
            return num * silnia(num - 1);
        }

        public static int RecursionSum(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            return nums[0] + RecursionSum(nums[1..]);
        }

        public static int FindRepeatingElement(string[] elements, string element)
        {

            if (elements.Length == 0) return 0; 

            if (elements[0] == element) return FindRepeatingElement(elements[1..], element) + 1;
            else return FindRepeatingElement(elements[1..], element) + 0;
        }

        public static string FizzBuzz(int num)
        {

            return "";
        }
    }
}
