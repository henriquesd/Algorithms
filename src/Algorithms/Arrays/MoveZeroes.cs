namespace Algorithms.Arrays
{
    /// <summary>
    /// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    /// Note that you must do this in-place without making a copy of the array.
    /// </summary>
    public static class MoveZeroes
    {
        public static int[] MoveZeroesExample1(int[] nums)
        {
            int writer = 0;

            for (int reader = 0; reader < nums.Length; reader++)
            {
                if (nums[reader] != 0)
                {
                    // Move the non-zero element to the position pointed by the writer
                    nums[writer] = nums[reader];
                    
                    // Increment the writer to the next position
                    writer++;
                }
            }

            // Fill the remaining elements with zeros
            while (writer < nums.Length)
            {
                nums[writer] = 0;
                writer++;
            }

            return nums;
        }

        public static int[] MoveZeroesExample2(int[] nums)
        {
            int n = nums.Count();

            // Count the zeroes
            int numZeroes = 0;
            for (int i = 0; i < n; i++)
            {
                numZeroes += (nums[i] == 0) ? 1 : 0;
            }

            // Make all the non-zero elements retain their original order
            List<int> ans = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != 0)
                {
                    ans.Add(nums[i]);
                }
            }

            // Move all zeroes to the end
            while (numZeroes-- > 0)
            {
                ans.Add(0);
            }

            // Update the original list
            for (int i = 0; i < n; i++)
            {
                nums[i] = ans[i];
            }

            return nums;
        }

        public static int[] MoveZeroesExample3(int[] nums)
        {
            int lastNonZeroFoundAt = 0;

            // If the current element is not 0, then we need to
            // append it just in front of last non-zero element we found.
            for (int i = 0; i < nums.Count(); i++)
            {
                if (nums[i] != 0)
                {
                    nums[lastNonZeroFoundAt++] = nums[i];
                }
            }

            // After we have finished processing new elements,
            // all the non-zero elements are already at the beginning of the list.
            // We just need to fill the remaining list with 0's.
            for (int i = lastNonZeroFoundAt; i < nums.Count(); i++)
            {
                nums[i] = 0;
            }

            return nums;
        }

        public static int[] MoveZeroesExample4(int[] nums)
        {
            for (int lastNonZeroFoundAt = 0, cur = 0; cur < nums.Count(); cur++)
            {
                if (nums[cur] != 0)
                {
                    Swap(nums, lastNonZeroFoundAt++, cur);
                }
            }

            return nums;
        }

        static void Swap(int[] nums, int index1, int index2)
        {
            int temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = temp;
        }

        /// <summary>
        /// Go through the array and gather all zeros on our road,
        /// every time a 0 is found, the snow ball gets bigger.
        /// When finding a non zero number, then swap with the most left zero.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] MoveZeroesExample5(int[] nums)
        {
            int snowBallSize = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    snowBallSize++;
                }
                else if (snowBallSize > 0)
                {
                    int temp = nums[i];
                    nums[i] = 0;
                    nums[i - snowBallSize] = temp;
                }
            }

            return nums;
        }
    }
}