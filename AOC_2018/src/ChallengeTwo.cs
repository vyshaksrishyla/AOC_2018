using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AOC_2018
{
    internal class ChallengeTwo
    {
        private static readonly string[] Input = File.ReadAllLines(@"resource\ChallengeTwo.txt");

        private static readonly StringBuilder _stringBuilder = new StringBuilder();

        public static int PartOne()
        {
            var hashSetOfCharacters = new HashSet<char>();
            var numberOfDoubles = 0;
            var numberOfThrees = 0;

            foreach (var readLine in Input)
            {
                var charactersOfLine = readLine.ToCharArray();
                var isDoublePresent = false;
                var isTriplePresent = false;

                foreach (var character in charactersOfLine)
                {

                    if (hashSetOfCharacters.Contains(character))
                        continue;

                    hashSetOfCharacters.Add(character);

                    var countOfCharacters = charactersOfLine.Count(x => x == character);

                    if (countOfCharacters != 2 && countOfCharacters != 3)
                        continue;

                    switch (countOfCharacters)
                    {

                        case 2 when !isDoublePresent:
                            numberOfDoubles++;
                            isDoublePresent = true;
                            break;

                        case 3 when !isTriplePresent:
                            numberOfThrees++;
                            isTriplePresent = true;
                            break;
                    }
                }

                hashSetOfCharacters.Clear();
            }

            return numberOfDoubles * numberOfThrees;
        }

        public static string PartTwo()
        {
            var numberOfStrings = Input.Length;
            var resultString = string.Empty;

            for(var i = 0; i < numberOfStrings - 2; i++)
            {
                for (var j = i + 1; j < numberOfStrings - 1; j++)
                {
                    resultString = DifferByOneCharacter(Input[i], Input[j]);

                   if (!string.IsNullOrEmpty(resultString))
                        return resultString;
                }
            }

            return resultString;
        }

        private static string DifferByOneCharacter(string stringOne, string stringTwo)
        {
            var differByOneCharacter = false;

            _stringBuilder.Clear();

            for (var i = 0; i < stringOne.Length; i++)
            {
                if (stringOne[i] != stringTwo[i] && differByOneCharacter)
                    return string.Empty;

                if (stringOne[i] != stringTwo[i])
                    differByOneCharacter = true;
                else
                    _stringBuilder.Append(stringOne[i]);
            }
            
            return _stringBuilder.ToString();
        }
    }
}
