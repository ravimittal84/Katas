namespace TwoSum
{
    using System;
    using System.Collections.Generic;

    class TwoSum
    {
        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < list.Count; i++)
            {
                int num = list[i];
                int remain = sum - num;
                int j;
                if (dict.TryGetValue(remain, out j))
                    return new Tuple<int, int>(i, j);

                if (!dict.ContainsKey(num)) dict.Add(num, i);
            }

            return null;
        }

        public static void Main(string[] args)
        {
            Tuple<int, int> indices = FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
        }
    }
}
