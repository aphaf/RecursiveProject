using RecursiveLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveTest
{
    public class FibonacciTest
    {
        [Fact]
        public void ShouldFindFibonacciNumber()
        {
            int expected = 13;
            Fibonacci fibonacci = new Fibonacci();
            int actual = fibonacci.FindFibonacciNumbers(6, new List<int>()).Last();

            Assert.Equal(expected, actual);
        }
    }
}
