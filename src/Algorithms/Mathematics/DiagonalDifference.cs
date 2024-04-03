namespace Algorithms.Mathematics
{
    public static class DiagonalDifference
    {
        // Given a square matrix, it calculates the absolute difference between the sums of its diagonals.

        public static int MatrixDiagonalDifference(List<List<int>> matrix)
        {
            int leftDiagonalSum = 0;
            int rightDiagonalSum = 0;
            int matrixCount = matrix.Count;

            for (int i = 0; i < matrixCount; i++)
            {
                leftDiagonalSum += matrix[i][i];
                rightDiagonalSum += matrix[i][matrixCount - 1 - i];
            }

            var diff = Math.Abs(leftDiagonalSum - rightDiagonalSum);

            return diff;
        }
    }
}
