using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class FizzBuzzDemo2Tests
    {
        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void FizzBuzzExample1_ShouldReturnExpectedResult(int n, string[] expectedResult)
        {
            var result = FizzBuzzDemo2.FizzBuzzExample1(n);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void FizzBuzzExample2_ShouldReturnExpectedResult(int n, string[] expectedResult)
        {
            var result = FizzBuzzDemo2.FizzBuzzExample2(n);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void FizzBuzzExample3_ShouldReturnExpectedResult(int n, string[] expectedResult)
        {
            var result = FizzBuzzDemo2.FizzBuzzExample3(n);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void FizzBuzzExample4_ShouldReturnExpectedResult(int n, string[] expectedResult)
        {
            var result = FizzBuzzDemo2.FizzBuzzExample4(n);

            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> ValuesToTest()
        {
            yield return new object[] { 3, new string[] { "1", "2", "Fizz" } };
            yield return new object[] { 5, new string[] { "1", "2", "Fizz", "4", "Buzz" } };
            yield return new object[] { 15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" } };
        }
    }
}
