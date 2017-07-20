using System.Collections.Generic;

namespace FizzBuzz
{
    //Double check lock singleton
    public sealed class FizzBuzzRules : List<IRule>
    {
        private FizzBuzzRules()
        {
            Add(new FizzRule());
            Add(new BuzzRule());
            Add(new GeneralRule());
        }

        private static volatile FizzBuzzRules _instance;
        private static object _lock = new object();

        public static FizzBuzzRules Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new FizzBuzzRules();
                    }
                }

                return _instance;
            }
        }
    }
}