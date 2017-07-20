using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var _builder = new Builder(FizzBuzzRules.Instance);
            var num = Console.ReadLine();
            for (int i = 1; i <= int.Parse(num); i++)
            {
                Console.WriteLine(_builder.Build(i));
            }
            Console.ReadKey();

        }
    }
}
