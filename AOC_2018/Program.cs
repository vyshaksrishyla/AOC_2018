using System;

namespace AOC_2018
{
    internal class Program
    {
        private static readonly string _welcomeMessage = @"Hey there !
Enter a number from 1 to 25 to see the solution to the problem from Advent Of Code 2018.";

        private static readonly string _problemNumberMessage = @"Enter a Problem number:";
        private static readonly string _solutionDoesNotExistMessage = @"Solution to the problem does not exist.";
        private static readonly string _programTerminationMessage = @"Enter any character to end the program.";
        private static readonly string _enterValidNumberMessage = @"Enter a valid number.";

        static void Main(string[] args)
        {
            Console.WriteLine(_welcomeMessage);
            var problemNumber = GetProblemNumber();

            switch (problemNumber)
            {
                case 1:
                    Console.WriteLine($"Part 1 : {ChallengeOne.PartOne()}; Part 2 : {ChallengeOne.PartTwo()}");
                    break;
                case 2:
                    Console.WriteLine($"Part 1 : {ChallengeTwo.PartOne()}; Part 2 : {ChallengeTwo.PartTwo()}");
                    break;
                default:
                    Console.WriteLine(_solutionDoesNotExistMessage);
                    break;
            }

            Console.WriteLine(_programTerminationMessage);
            Console.ReadLine();
        }

        private static int GetProblemNumber()
        {
            while (true)
            {
                Console.Write(_problemNumberMessage);
                var enteredProblemNumber = Console.ReadLine();

                if (Int32.TryParse(enteredProblemNumber, out int result))
                    return result;

                Console.WriteLine(_enterValidNumberMessage);
            }
        }
    }
}
