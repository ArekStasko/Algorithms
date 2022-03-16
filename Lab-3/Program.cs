using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(GetRestCoins(128));
            //Console.WriteLine(fibonnaci(4));

            Item[] items = new Item[]
            {
            new Item(25, 1),
            new Item(35, 2),
            new Item(15, 1),
            new Item(30, 3),
            new Item(50, 3),
            new Item(25, 1)
            };
            

            int sum = GetTotalSum(items);
            Console.WriteLine(sum);
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

        public static long fibMemo(int n)
        {
            int mem1 = 0;
            int mem2 = 0;
            int result = 1;
            for (int i = 0; i < n; i++)
            {
                mem1 = mem2;
                mem2 = result;
                result = mem1 + mem2;
            }
            return result;
        }

        
        public static int GetTotalSum(Item[] items)
        {
            var itemsList = items.ToList();
            int sum = 0;
            int bagSize = 0;

            while (bagSize < 4 && itemsList.Count != 0) { 
                var bestValue = itemsList[0];

                for(int j = 1; j < itemsList.Count; j++)
                { 
                    if (bestValue.Value < itemsList[j].Value && bagSize + itemsList[j].Weight <= 4)
                    {
                        bestValue = items[j];
                    }
                }
                itemsList.Remove(bestValue);
                bagSize += bestValue.Weight;
                sum += bestValue.Value;
            }

            return sum;
        }

    }

    public class Item
    {
        public int Value { get; set; }
        public int Weight { get; set; }

        public Item(int value, int weight)
        {
            Value = value;
            Weight = weight;
        }
    }
}
