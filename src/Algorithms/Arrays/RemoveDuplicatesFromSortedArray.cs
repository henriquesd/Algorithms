namespace Algorithms.Arrays
{
    public static class RemoveDuplicatesFromSortedArray
    {
        // Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that
        //   each unique element appears only once.
        // The relative order of the elements should be kept the same. Then return the number of unique elements in nums.
        // Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:
        //  1. Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially.
        //    The remaining elements of nums are not important as well as the size of nums.
        //  2. Return k.
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            var insertIndex = 1;

            // Iterate through the array starting from the second element;
            for (int i = 1; i < nums.Length; i++)
            { 
                // Compare if the previous element is different than the current element;
                if (nums[i - 1] != nums[i])
                {
                    // If they are different, move the element to the insertIndex position;
                    nums[insertIndex] = nums[i];

                    insertIndex++;
                }
            }

            // The value of insertIndex represents the number of unique elements
            // and also serves as the length of the resulting array;
            return insertIndex;
        }
    }
}
