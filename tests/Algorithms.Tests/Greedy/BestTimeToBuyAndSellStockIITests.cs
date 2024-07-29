using Algorithms.Greedy;
using Xunit;

namespace Algorithms.Tests.Greedy
{
    public class BestTimeToBuyAndSellStockIITests
    {
        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
        [InlineData(new int[] { 5 }, 0)]
        [InlineData(new int[] { 1, 1, 1, 1, 1 }, 0)]
        [InlineData(new int[] { 3, 3, 5, 0, 0, 3, 1, 4 }, 8)]

        public void MaxProfit_ShouldReturnMaxProfit(int[] inputArray, int expectedProfit)
        {
            var result = BestTimeToBuyAndSellStockII.MaxProfit(inputArray);

            Assert.Equal(expectedProfit, result);
        }
    }
}