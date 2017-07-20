namespace FizzBuzz
{

    public class GeneralRule : IRule
    {
        public string Calculate(string value, int num) =>
            (!string.IsNullOrWhiteSpace(value)) ? "" : num.ToString();
    }
}