using System;
using System.IO;

namespace AOC_2018
{
    internal class ChallengeOne
    {
        private static readonly string[] Input = File.ReadAllLines(@"Inputs\ChallengeOne.txt");

        private static int _result = 0;

        public static int GetSolution()
        {
            foreach (string readLine in Input)
            {
                if (Int32.TryParse(readLine, out int convertedValue))
                {
                    _result += convertedValue;
                }
                
            }
            return _result;
        }
    }
}
