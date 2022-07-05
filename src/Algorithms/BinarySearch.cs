namespace Algorithms
{
    public static class BinarySearch
    {
        public static int? FindNumberPositionInSortedArray(int[] inputArray, int searchedNumber)
        {
            int min = 0;
            int max = inputArray.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (searchedNumber == inputArray[mid])
                {
                    return mid;
                } else if (searchedNumber < inputArray[mid])
                {
                    max = mid - 1;
                } else
                {
                    min = mid + 1;
                }
            }

            return null;
        }

        // It's also possible to use the method Array.BinarySearch(Array array, object? value)
        // this method returns the index of the specified value in the array,
        // if the value is not found, a negative number is returned;
    }
}
