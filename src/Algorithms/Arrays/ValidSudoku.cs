namespace Algorithms.Arrays
{
    public static class ValidSudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            // Arrays to track numbers seen in rows, columns, and sub-boxes;
            HashSet<char>[] rows = new HashSet<char>[9];
            HashSet<char>[] cols = new HashSet<char>[9];
            HashSet<char>[] boxes = new HashSet<char>[9];

            for (int i = 0; i < 9; i++)
            {
                rows[i] = new HashSet<char>();
                cols[i] = new HashSet<char>();
                boxes[i] = new HashSet<char>();
            }

            // Iterate through each cell in the board;
            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    char num = board[r][c];

                    // Skip empty cells ('.');
                    if (num == '.') continue;

                    // Check if the number is already seen in the current row;
                    if (rows[r].Contains(num)) return false; // If yes, the board is invalid;
                    rows[r].Add(num); // Otherwise, add the number to the row set;

                    // Check if the number is already seen in the current column;
                    if (cols[c].Contains(num)) return false; // If yes, the board is invalid;
                    cols[c].Add(num); // Otherwise, add the number to the column set;

                    // Check if the number is already seen in the current 3x3 sub-box.
                    int boxIndex = (r / 3) * 3 + (c / 3);
                    if (boxes[boxIndex].Contains(num)) return false; // If yes, the board is invalid;
                    boxes[boxIndex].Add(num); // Otherwise, add the number to the box set;
                }
            }

            // If no conflicts are found in rows, columns, and sub-boxes, the board is valid.
            return true;
        }
    }
}