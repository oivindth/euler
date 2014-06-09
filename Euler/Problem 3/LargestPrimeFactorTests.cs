using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Euler.Problem_3
{
    [TestFixture]
    public class LargestPrimeFactorTests
    {
        // first get list of prime factors. 
        // then find largest in the list.


        [TestCase(1, new int []{})]
        [TestCase(2, new int[] {2 })]
        [TestCase(3, new int[] {3 })]
        //[TestCase(4, new int[] { 2,2 })]
        public void Test_PrimeFactorsOf(int n, int[] expected)
        {
            var factors = new PrimeFactors();
            Assert.AreEqual(expected, factors.FactorsOf(n));
        }

    }

    public class PrimeFactors
    {
        public int [] FactorsOf(int n)
        {
            var factors = new List<int>();
            if (n%2 == 0 ) factors.Add(n);
            if (n%3 == 0) factors.Add(n);
            
            return factors.ToArray();
        }
    }
}
