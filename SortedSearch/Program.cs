using System;

namespace SortedSearch
{
    public class SortedSearch
    {
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {
            if (sortedArray[0] >= lessThan) return 0;
            if (sortedArray[sortedArray.Length - 1] < lessThan) return sortedArray.Length;
            return Count(sortedArray, lessThan);
        }

        private static int Count(int[] sortedArray, int lessThan)
        {
            int first = 1, last = sortedArray.Length - 1;
            while (first <= last)
            {
                int mid = (first + last) / 2;
                if (lessThan < sortedArray[mid])
                    last = mid - 1;
                if (lessThan > sortedArray[mid])
                    first = mid + 1;
                else
                    return mid;
            }

            return 0;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(CountNumbers(new int[] { 1, 3, 5, 7 }, 3));
            Console.ReadKey();
        }
    }
}
