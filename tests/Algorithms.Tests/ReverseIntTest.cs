using Xunit;

namespace Algorithms.Tests
{
    public class ReverseIntTest
    {
        [Theory]
        [InlineData(15, 51)]
        [InlineData(981, 189)]
        [InlineData(500, 5)]
        [InlineData(-15, -51)]
        [InlineData(-90, -9)]
        public void Reverse_ShouldReverseInt(int number, int expectedNumber)
        {
            var result = ReverseInt.Reverse(number);

            Assert.Equal(result, expectedNumber);
        }
    }
}
