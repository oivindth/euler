using System.Collections.Generic;

namespace Euler.Problem2
{
    public class Fibonacci
    {

        public int SumOfEvenBelow(int maxValueForFib)
        {
            var sum = 0;
            var i = 1;
            for (var fib = Fib(1); fib <= maxValueForFib; fib = Fib(i++))
                if (fib % 2 == 0) sum += fib;
            return sum;
        }

        public int Fib(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            return Fib(n - 1) + Fib(n-2);
        }

        public int Sum(int n)
        {
            var sum = 0;
            for (; n >0; n--)
                sum += Fib(n);
            return sum;
        }

        public List<int> CalculateFibonaccisForTerms(int terms)
        {
            var fibonaccis = new List<int>();
            for (; terms > 0; terms--)
                fibonaccis.Add(Fib(terms));
            fibonaccis.Reverse();
            return fibonaccis;
        }
    }
}
