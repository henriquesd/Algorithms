using System.Collections.Immutable;

namespace Algorithms
{
    public static class SmallestPositiveValue
    {
        /// <summary>
        /// This function will return the smalles positive integer that does not occur in the array.
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static int Execute(int[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0) return 1;

            // Create a HashSet<int> from the input array, excluding negative numbers and zero;
            var hashSet = new HashSet<int>(inputArray.Where(x => x > 0));

            int smallestValue = 1;

            while (hashSet.Contains(smallestValue))
            {
                smallestValue++;
            }

            return smallestValue;
        }


        public static int ExecuteWithSortedArray(int[] inputArray)
        {
            if (inputArray is null || inputArray.Length == 0) return 1;

            var smallestValue = 1;

            // Filter to have only positive values in array;
            inputArray = inputArray.Where(n => n > 0).OrderBy(n => n).ToArray();

            // Loop through the sorted array and find the first missing integer.
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (!inputArray[i].Equals(smallestValue) && smallestValue > 1)
                {
                    smallestValue++;
                }
            }

            if (inputArray.Contains(smallestValue))
            {
                while (inputArray.Contains(smallestValue))
                {
                    smallestValue++;
                }
            }

            return smallestValue;
        }
    }
}
