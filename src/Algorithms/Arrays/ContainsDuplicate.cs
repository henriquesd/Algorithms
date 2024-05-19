namespace Algorithms.Arrays
{
    // Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
    public static class ContainsDuplicate
    {
        public static bool ContainsDuplicateExample1(int[] nums)
        {
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ContainsDuplicateExample2(int[] nums)
        {
            // Initialize a HashSet to store unique elements from the array;
            HashSet<int> seen = new HashSet<int>();

            foreach (int num in nums)
            {
                if (!seen.Add(num))
                {
                    return true;
                }
            }

            return false;
        }
    }
}