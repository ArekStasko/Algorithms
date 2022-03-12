using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetRestCoins(-1));
            Console.WriteLine(fibonnaci(4));
        }


        public static string GetRestCoins(int rest)
        {
            if (rest < 0) return "Ask for more money !";

            int[] coinsValues = new int[] {5, 2, 1};
            int coinCount = 0;

            int[] coinsCount = new int[] { 0, 0, 0 };
            do
            {
                if (rest >= coinsValues[coinCount])
                {
                    rest = rest - coinsValues[coinCount];
                    coinsCount[coinCount]++;
                }
                else
                    coinCount++;
            } while (rest != 0);

            return $"5zl: {coinsCount[0]}; 2zl: {coinsCount[1]}; 1zl: {coinsCount[2]}";
        }


        public static long fibMem(int n, Dictionary<int, long> mem)
        {
            if (n < 2)
            {
                return 1;
            }

            if (!mem.ContainsKey(n - 1))
            {
                mem[n - 1] = fibMem(n - 1, mem);
            }
            if(!mem.ContainsKey(n - 2))
            {
                mem[n-2] = fibMem(n - 2, mem);
            }

            return mem[n - 1] + mem[n - 2];
        }

        public static long fibonnaci(int n)
        {
            return fibMem(n, new Dictionary<int, long>());
        }
    }
}
