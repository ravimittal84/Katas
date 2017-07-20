namespace FizzBuzz
{

    public class BuzzRule : IRule
    {
        public string Calculate(string value, int num) =>
            (num % 5 == 0) ? "Buzz" : "";
    }
}