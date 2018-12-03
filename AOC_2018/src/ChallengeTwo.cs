using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace AOC_2018
{
    class ChallengeTwo
    {
        public static int Part1()
        {
            var input = File.ReadAllLines(@"resource\ChallengeTwo.txt");
            var hashSetOfCharacters = new HashSet<char>();
            var numberOfDoubles = 0;
            var numberOfThrees = 0;

            foreach (var readLine in input)
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
    }
}
