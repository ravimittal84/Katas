namespace FizzBuzz
{

    public class Builder : IBuilder
    {
        private readonly FizzBuzzRules _rules;

        public Builder(FizzBuzzRules rules)
        {
            _rules = rules;
        }
        public string Build(int i)
        {
            var result = "";
            foreach (IRule rule in _rules)
            {
                result += rule.Calculate(result, i);
            }

            return result;
        }
    }
}