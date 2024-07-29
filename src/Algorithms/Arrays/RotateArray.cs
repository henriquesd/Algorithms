namespace Algorithms.Arrays
{
    // Given an integer array nums, rotate the array to the right by k steps, where k is non-negative;
    public static class RotateArray
    {
        public static int[] Rotate(int[] nums, int k)
        {
            int numsLength = nums.Length;

            // Ensure that if "k" is greater than the length of the array, 
            // it will not rotate the array more than necessary;
            k = k % numsLength;

            // Reverse the entire array;
            Reverse(nums, 0, numsLength - 1);

            // Reverse the first k elements;
            Reverse(nums, 0, k - 1);

            // Reverse the remaining n - k elements;
            Reverse(nums, k, numsLength - 1);

            return nums;
        }

        public static void Reverse(int[] nums, int start, int end)
        {
            // Swap elements from the start and end of the array until they meet in the middle;
            while (start < end)
            {
                // Temporarily store the value at the start index;
                int temp = nums[start];

                // Assign the value at the end index to the start index;
                nums[start] = nums[end];

                // Assign the temporarily stored value to the end index;
                nums[end] = temp;

                // Move the start index forward
                start++;

                // Move the end index backward
                end--;
            }
        }
    }
}