using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(Console.ReadLine()));
            Console.ReadKey();
        }

        public static bool IsPalindrome(string word)
        {
            word = word.ToLower();
            var len = word.Length;
            if (len < 2) return true;

            if (word[0] != word[len - 1]) return false;

            return IsPalindrome(word.Substring(1, len - 2));
        }
    }
}
