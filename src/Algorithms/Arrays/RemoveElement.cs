namespace Algorithms.Arrays
{
    // Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.The order of the elements may be changed.Then return the number of elements in nums which are not equal to val.
    // in-place: https://en.wikipedia.org/wiki/In-place_algorithm
    public static class RemoveElement
    {
        public static int Remove(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0) return 0;

            int numbersNotEqualToVal = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[numbersNotEqualToVal] = nums[i];
                    numbersNotEqualToVal++;
                }
            }

            return numbersNotEqualToVal;
        }

    }
}
