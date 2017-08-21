using System;

namespace Bowling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the scores separated by spaces.");
            var scores = Console.ReadLine();
            int currentScore = 0;
            foreach (string frame in scores.Split(' '))
            {
                int framescore = CalculateScore(frame);
                currentScore += framescore;
            }

            Console.Write($"Final Score: {currentScore}");
            Console.ReadKey();

        }

        private static int CalculateScore(string frame)
        {
            int framescore = 0;
            foreach (char turn in frame.ToUpper())
            {
                if (turn == 'X')
                {
                    framescore += 10;
                }

                else if (turn == '/')
                {
                    framescore = 10;
                }

                else if (turn == '-')
                {
                    // do nothing
                }

                else
                {
                    framescore += int.Parse(turn.ToString());
                }
            }

            return framescore;
        }
    }
}
