using System.Collections.Generic;
using System.Linq;

namespace Euler
{
    public class ProblemOne
    {
        public int CalculateTheSumOfMultiplesThreeAndFive(int below)
        {
            var multiples = GetListOfNumbersThatAreMultiplesOfThreeOrFiveBelowInput(below);
            return multiples.Sum();
        }

        public List<int> GetListOfNumbersThatAreMultiplesOfThreeOrFiveBelowInput(int below)
        {
            var multiples = new List<int>();
            for (var i = 1; i < below; i++)
                if (IsMultipleOfThreeOrFive(i)) multiples.Add(i);
            return multiples;
        }

        public bool IsMultipleOfThreeOrFive(int number)
        {
            return (number%3 == 0 || number%5 == 0);
        }
    }
}