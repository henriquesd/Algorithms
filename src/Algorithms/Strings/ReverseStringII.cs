namespace Algorithms.Strings
{
    // Write a function that reverses a string. The input string is given as an array of characters s.
    // You must do this by modifying the input array in-place with O(1) extra memory;
    public static class ReverseStringII
    {
        // Two Pointers Approach
        // In this approach, two pointers are used to process two array elements at the same time.
        // Usual implementation is to set one pointer in the beginning and one at the end and then to move them until they both meet;
        // Time complexity: O(N) to swap N/2 elements;
        // Space complexity: O(1), it's a constant space solution;
        public static char[] ReverseString(char[] s)
        {
            // Initialize two pointers: left at the start of the array, right at the end;
            int left = 0;
            int right = s.Length - 1;

            // Loop until the two pointers meet in the middle;
            while (left < right)
            {
                // Store the character at the left pointer in a temporary variable;
                char temp = s[left];

                // Swap the characters at the left and right pointers;
                s[left] = s[right];
                s[right] = temp;

                // Move the left pointer one step to the right
                left++;

                // Move the right pointer one step to the left
                right--;
            }

            // Return the reversed array;
            return s;
        }


        // Time complexity: O(N) to perform N/2 swaps;
        // Space complexity: O(N) to keep the recursion stack;
        public static char[] ReverseStringWithRecursion(char[] s)
        {
            // Call the helper method with the initial indices;
            Reverse(s, 0, s.Length - 1);
            
            return s;
        }

        // Recursive helper method to reverse the array in-place;
        public static void Reverse(char[] s, int left, int right)
        {
            // Base case: If left index is greater than or equal to right index, return;
            if (left >= right) return;

            // Swap the characters at left and right indices;
            char tmp = s[left];
            s[left] = s[right];
            s[right] = tmp;

            // Recursive call to continue reversing the remaining array;
            Reverse(s, ++left, --right);
        }
    }
}