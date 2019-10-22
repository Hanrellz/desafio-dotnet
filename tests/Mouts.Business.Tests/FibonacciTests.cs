using NUnit.Framework;
using Mouts.Business;
using System.Collections.Generic;
using System;

namespace Tests
{
    public class FibonacciTests
    {

        [Test]
        public void GetSequency_Should_Return_Fibonnaci_Sequency_Separed_By_Comma([Values(10, 20, 35)]int fibonacciIndex)
        {
            IDictionary<int, string> testSequencies = new Dictionary<int, string>()
            {
                {10, "1,1,2,3,5,8,13,21,34,55"},
                {20, "1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987,1597,2584,4181,6765"},
                {35, "1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987,1597,2584,4181,6765,10946,17711,28657,46368,75025,121393,196418,317811,514229,832040,1346269,2178309,3524578,5702887,9227465"},
            };

            this.TemplateTestMethod<int ,string>(Fibonacci.GetSequency, testSequencies, fibonacciIndex);
        }

        [Test]
        public void GetAmount_Should_Return_The_Sum_Of_All_Sequency_Numbers([Values(10, 20, 35)]int fibonacciIndex)
        {
            IDictionary<int, long> testSequencies = new Dictionary<int, long>()
            {
                {10, 143},
                {20, 17710},
                {35, 24157816}
            };

            this.TemplateTestMethod<int, long>(Fibonacci.GetAmount, testSequencies, fibonacciIndex);
        }

        [Test]
        public void GetValueFromIndex_Should_Return_Last_Sequency_Value([Values(10, 20, 35)]int fibonacciIndex)
        {
            IDictionary<int, long> testSequencies = new Dictionary<int, long>()
            {
                {10, 55},
                {20, 6765},
                {35, 9227465}
            };

            this.TemplateTestMethod<int, long>(Fibonacci.GetValueFromIndex, testSequencies, fibonacciIndex);
        }

        [TestCase(1304969544928657)]
        [TestCase(2111485077978050)]
        [TestCase(3416454622906707)]
        [TestCase(5527939700884757)]
        [TestCase(8944394323791464)]
        public void GetIndexFromValue_Should_Return_Fibonacci_Index_From_Fibonacci_Sequency_Value(long fibonacciIndex)            
        {
            IDictionary<long, int> testSequencies = new Dictionary<long, int>()
            {
                {1304969544928657, 74},
                {2111485077978050, 75},
                {3416454622906707, 76},
                {5527939700884757, 77},
                {8944394323791464, 78}
            };

            this.TemplateTestMethod<long, int>(Fibonacci.GetIndexFromValue, testSequencies, fibonacciIndex);
        }

        private void TemplateTestMethod<TInput,TResult>(Func<TInput, TResult> testMethod, IDictionary<TInput, TResult> expectedResults, TInput fibonacciIndex)
        {
            TResult result = testMethod(fibonacciIndex);

            Assert.AreEqual(expectedResults[fibonacciIndex], result);
        }
    }
}