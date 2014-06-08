using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Euler
{   //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    //Find the sum of all the multiples of 3 or 5 below 1000.
    [TestFixture]
    public class MultiplesOfThreeAndFiveTests
    {
        private ProblemOne _problemOne;

        [SetUp]
        public void SetUp()
        {
            _problemOne = new ProblemOne();   
        }

        [TestCase(10, 23)]
        [TestCase(1000, 233168)]
        public void Test_SumOfMultiplesOfThreeAndFiveBelow(int below, int expected)
        {
            var result = _problemOne.CalculateTheSumOfMultiplesThreeAndFive(below);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Test_GetsListOfNNumbersThatAreMultiplesOfThreeOrFiveBelowInput()
        {
            var belowTen = _problemOne.GetListOfNumbersThatAreMultiplesOfThreeOrFiveBelowInput(10);
            var expectedNumbers = new List<int>() {3, 5, 6, 9};
            Assert.AreEqual(expectedNumbers, belowTen);

            var belowThirteen = _problemOne.GetListOfNumbersThatAreMultiplesOfThreeOrFiveBelowInput(13);
            expectedNumbers.Add(10);
            expectedNumbers.Add(12);
            Assert.AreEqual(expectedNumbers, belowThirteen);

        }

        [TestCase(1, false)]
        [TestCase(2, false)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(6, true)]
        public void Test_IsMultipleOfThreeOrFive(int number, bool isMultiple)
        {
            var problemOne = new ProblemOne();
            var res = problemOne.IsMultipleOfThreeOrFive(number);
            Assert.AreEqual(isMultiple, res);
        }

    }
}
