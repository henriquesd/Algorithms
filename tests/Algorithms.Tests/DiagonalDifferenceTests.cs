using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class DiagonalDifferenceTests
    {
        [Fact]
        public void MatrixDiagonalDifference_ShouldReuturnCorrectDifference()
        {
            // Arrange
            List<List<int>> matrix = new List<List<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 4, 5, 6 },
                new List<int> { 9, 8, 9 }
            };

            // Act
            int result = DiagonalDifference.MatrixDiagonalDifference(matrix);

            // Assert
            Assert.Equal(2, result);
        }
    }
}
