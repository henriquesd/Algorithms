namespace Algorithms.Arrays
{
    // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    // You may assume that each input would have exactly one solution, and you may not use the same element twice.
    // You can return the answer in any order;
    public static class TwoSum
    {
        public static int[]? Execute(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                // Calculate the complement of the current number by subtracting it from the target;
                int complement = target - nums[i];

                // Check if the complement is already in the dictionary;
                if (map.ContainsKey(complement))
                {
                    // Return the indices of the two numbers that add up to the target;
                    return new int[] { map[complement], i };
                }


                // Add the current number and its index to the dictionary;
                map[nums[i]] = i;
            }

            return null;
        }
    }
}