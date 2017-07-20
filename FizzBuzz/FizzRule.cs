namespace FizzBuzz
{

    public class FizzRule : IRule
    {
        public string Calculate(string value, int num) =>
            (num % 3 == 0) ? "Fizz" : "";
    }
}