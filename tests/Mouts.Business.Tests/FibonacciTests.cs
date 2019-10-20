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

            this.TemplateTestMethod<string>(Fibonacci.GetSequency, testSequencies, fibonacciIndex);
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

            this.TemplateTestMethod<long>(Fibonacci.GetAmount, testSequencies, fibonacciIndex);
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

            this.TemplateTestMethod<long>(Fibonacci.GetValueFromIndex, testSequencies, fibonacciIndex);
        }
        private void TemplateTestMethod<TResult>(Func<int, TResult> testMethod, IDictionary<int, TResult> expectedResults, int fibonacciIndex)
        {
            TResult result = testMethod(fibonacciIndex);

            Assert.AreEqual(expectedResults[fibonacciIndex], result);
        }
    }
}