namespace Algorithms.Arrays
{
    // Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
    // You must implement a solution with a linear runtime complexity and use only constant extra space;
    public static class SingleNumber
    {
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        public static int SingleNumberExample1(int[] nums)
        {
            // Initialize result to 0. This will be used to store the final single number;
            int result = 0;

            // Iterate through each number in the array;
            foreach (int i in nums)
            {
                // XOR the current number with the result
                // XOR operation will cancel out numbers that appear in pairs,
                // leaving the single number that appears only once;
                result ^= i;
            }

            // Return the result which now holds the single number;
            return result;
        }

        // Time Complexity: O(n)
        // Space Complexity: O(n)
        public static int SingleNumberExample2(int[] nums)
        {
            // Initialize a hashtable to keep track of the count of each number;
            var hashTable = new Dictionary<int, int>();

            // Iterate through each number in the array;
            foreach (int num in nums)
            {
                // If the number is already in the dictionary, increment its count;
                if (hashTable.ContainsKey(num))
                {
                    hashTable[num]++;
                }
                // If the number is not in the dictionary, add it with a count of 1;
                else
                {
                    hashTable[num] = 1;
                }
            }

            // Iterate through the numbers again;
            foreach (int num in nums)
            {
                // If the count of the number is 1, return that number;
                // This is the unique number that appears only once;
                if (hashTable[num] == 1)
                {
                    return num;
                }
            }

            // If no unique number is found (though per problem constraints, this shouldn't happen),
            // return 0 as a default (or you could throw an exception)
            return 0;
        }

        // Time Complexity: O(n)
        // Space Complexity: O(n)
        public static int SingleNumberExample3(int[] nums)
        {
            // Initialize variables to store the sum of unique numbers and the sum of all numbers;
            int sumOfSet = 0, sumOfNums = 0;

            // Initialize a HashSet to store unique numbers encountered;
            HashSet<int> set = new HashSet<int>();

            // Iterate through the array;
            for (int i = 0; i < nums.Length; i++)
            {
                // If the number is not in the set, add it to the set and update sumOfSet;
                if (!set.Contains(nums[i]))
                {
                    set.Add(nums[i]);
                    sumOfSet += nums[i];
                }

                // Update sumOfNums with the current number;
                sumOfNums += nums[i];
            }

            // The unique number is calculated using the formula: 2 * sumOfSet - sumOfNums
            // Explanation: The difference between the sum of all unique numbers (2 * sumOfSet) and 
            // the sum of all numbers in the array (sumOfNums) gives the value of the unique number;
            return 2 * sumOfSet - sumOfNums;
        }

        // Time Complexity: O(n^2)
        // Space Complexity: O(n)
        public static int SingleNumberExample4(int[] nums)
        {
            // Initialize a list to store numbers without duplicates;
            List<int> no_duplicate_list = new List<int>();

            // Iterate through each number in the array;
            foreach (int i in nums)
            {
                // If the list does not contain the current number, add it;
                if (!no_duplicate_list.Contains(i))
                {
                    no_duplicate_list.Add(i);
                }
                // If the list already contains the current number, remove it;
                else
                {
                    no_duplicate_list.Remove(i);
                }
            }

            // The remaining element in the list is the unique number;
            return no_duplicate_list[0];
        }
    }
}