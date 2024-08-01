using Algorithms.Strings;
using Xunit;

namespace Algorithms.Tests.Strings
{
    public class ReverseIntegerTests
    {
        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(0, 0)]
        [InlineData(1534236469, 0)] // Exceeds 32-bit signed integer range when reversed
        [InlineData(-2147483648, 0)] // Exceeds 32-bit signed integer range when reversed
        public void Reverse_ShouldReturnReversedInteger(int input, int expected)
        {
            var result = ReverseInteger.Reverse(input);
            
            Assert.Equal(expected, result);
        }
    }
}