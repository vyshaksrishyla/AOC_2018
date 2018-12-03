using System.Collections.Generic;
using System.IO;

namespace AOC_2018
{
    internal class ChallengeOne
    {
        private static readonly string[] Input = File.ReadAllLines(@"resource\ChallengeOne.txt");

        private static int _resultPart1 = 0;

        private static int _resultPart2 = 0;

        public static int PartOne()
        {
            foreach (string readLine in Input)
            {
                if (int.TryParse(readLine, out int convertedValue))
                {
                    _resultPart1 += convertedValue;
                }
            }

            return _resultPart1;
        }

        public static int PartTwo()
        {
            HashSet<int> hashSetOfFrequencies = new HashSet<int>();

            hashSetOfFrequencies.Add(_resultPart2);

            while (true)
            {
                foreach (string readLine in Input)
                {
                    if (int.TryParse(readLine, out int convertedValue))
                    {
                        _resultPart2 += convertedValue;
                    }

                    if (hashSetOfFrequencies.Contains(_resultPart2))
                        return _resultPart2;

                    hashSetOfFrequencies.Add(_resultPart2);
                }
            }
        }
    }
}