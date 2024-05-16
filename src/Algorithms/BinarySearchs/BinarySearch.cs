namespace Algorithms.BinarySearchs
{
    public static class BinarySearch
    {
        // Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums.
        // If target exists, then return its index. Otherwise, return -1.
        // You must write an algorithm with O(log n) runtime complexity.
        public static int Search(int[] nums, int target)
        {
            // Initialize the left and right pointers for the search range;
            var left = 0;
            var right = nums.Length - 1;

            // Perform binary search as long as the search range is valid;
            while (left <= right)
            {
                // Calculate the middle index of the current search range;
                // We continuously divide the search range in half until the target element is found or the search range becomes empty;
                var middle = left + (right - left) / 2;

                // If the middle element is the target, return its index;
                if (nums[middle] == target) return middle;

                // If the target is greater than the middle element, search the right half
                if (nums[middle] < target) left = middle + 1;

                // If the target is smaller than the middle element, search the left half
                if (nums[middle] > target) right = middle - 1;
            }

            // If the target is not found, return -1;
            return -1;
        }

        // It's also possible to use the method Array.BinarySearch(Array array, object? value)
        // this method returns the index of the specified value in the array,
        // if the value is not found, a negative number is returned;
    }
}