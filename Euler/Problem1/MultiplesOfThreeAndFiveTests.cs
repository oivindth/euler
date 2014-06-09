using System.Collections.Generic;
using NUnit.Framework;

namespace Euler.Problem1
{   //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    //Find the sum of all the multiples of 3 or 5 below 1000.
    [TestFixture]
    public class MultiplesOfThreeAndFiveTests
    {
        private MultiplesOfThreeAndFive _multiplesOfThreeAndFive;

        [SetUp]
        public void SetUp()
        {
            _multiplesOfThreeAndFive = new MultiplesOfThreeAndFive();   
        }

        [TestCase(10, 23)]
        [TestCase(1000, 233168)]
        public void Test_SumOfMultiplesOfThreeAndFiveBelow(int below, int expected)
        {
            var result = _multiplesOfThreeAndFive.SumBelow(below);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Test_GetsListOfNNumbersThatAreMultiplesOfThreeOrFiveBelowInput()
        {
            var belowTen = _multiplesOfThreeAndFive.Below(10);
            var expectedNumbers = new List<int>() {3, 5, 6, 9};
            Assert.AreEqual(expectedNumbers, belowTen);

            var belowThirteen = _multiplesOfThreeAndFive.Below(13);
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
            var problemOne = new MultiplesOfThreeAndFive();
            var res = problemOne.IsMultipleOfThreeOrFive(number);
            Assert.AreEqual(isMultiple, res);
        }

    }
}
