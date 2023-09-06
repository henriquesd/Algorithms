using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class ReverseIntTests
    {
        public class ReverseTestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { 15, 51 };
                yield return new object[] { 981, 189 };
                yield return new object[] { 500, 5 };
                yield return new object[] { 4587, 7854 };
                yield return new object[] { -15, -51 };
                yield return new object[] { -90, -9 };
            }

            // This is required by the IEnumerable interface but can be empty;
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        [Theory]
        [ClassData(typeof(ReverseTestData))]
        public void Reverse_ShouldReverseInt(int number, int expectedNumber)
        {
            var result = ReverseInt.Reverse(number);

            Assert.Equal(expectedNumber, result);
        }

        [Theory]
        [ClassData(typeof(ReverseTestData))]
        public void ReverseWithString_ShouldReverseInt(int number, int expectedNumber)
        {
            var result = ReverseInt.ReverseWithString(number);

            Assert.Equal(expectedNumber, result);
        }


        [Theory]
        [ClassData(typeof(ReverseTestData))]
        public void ReverseExample3_ShouldReverseInt(int number, int expectedNumber)
        {
            var result = ReverseInt.ReverseExample3(number);

            Assert.Equal(expectedNumber, result);
        }
    }
}
