using System.Collections.Generic;
using System.Linq;

namespace Euler.Problem1
{
    public class MultiplesOfThreeAndFive
    {
        public int SumBelow(int n)
        {
            var multiples = Below(n);
            return multiples.Sum();
        }

        public List<int> Below(int n)
        {
            var multiples = new List<int>();
            for (var i = 1; i < n; i++)
                if (IsMultipleOfThreeOrFive(i)) multiples.Add(i);
            return multiples;
        }

        public bool IsMultipleOfThreeOrFive(int number)
        {
            return (number%3 == 0 || number%5 == 0);
        }
    }
}