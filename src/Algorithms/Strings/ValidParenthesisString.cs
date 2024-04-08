namespace Algorithms.Strings
{
    /// <summary>
    /// Given a string s containing only three types of characters: '(', ')' and '*', return true if s is valid.
    /// The following rules define a valid string:
    /// Any left parenthesis '(' must have a corresponding right parenthesis ')'.
    /// Any right parenthesis ')' must have a corresponding left parenthesis '('.
    /// Left parenthesis '(' must go before the corresponding right parenthesis ')'.
    /// '*' could be treated as a single right parenthesis ')' or a single left parenthesis '(' or an empty string "".
    /// </summary>
    public static class ValidParenthesisString
    {
        public static bool CheckValidStringExample1(string text)
        {
            Stack<int> openBrackets = new Stack<int>();
            Stack<int> asterisks = new Stack<int>();

            for (int i = 0; i < text.Length; i++)
            {
                char charValue = text[i];

                // If current character is an open bracket, push its index onto the stack
                if (charValue == '(')
                {
                    openBrackets.Push(i);
                }
                // If current character is an asterisk, push its index onto the stack
                else if (charValue == '*')
                {
                    asterisks.Push(i);
                }
                else // charValue == ')'
                {
                    // If there are open brackets available, use them to balance the closing bracket
                    if (openBrackets.Count > 0)
                    {
                        openBrackets.Pop();
                    }
                    // If no open brackets are available, use an asterisk to balance the closing bracket
                    else if (asterisks.Count > 0)
                    {
                        asterisks.Pop();
                    }
                    else
                    {
                        return false; // No matching left parenthesis or star
                    }
                }
            }

            // Check if there are remaining open brackets and asterisks that can balance them;
            while (openBrackets.Count > 0 && asterisks.Count > 0)
            {
                // If an open bracket appears after an asterisk, it cannot be balanced, return false;
                if (openBrackets.Pop() > asterisks.Pop())
                {
                    return false; // A left parenthesis is to the right of a star
                }
            }

            // If all open brackets are matched and there are no unmatched open brackets left, return true;
            return openBrackets.Count == 0;
        }

        // Top-Down Dynamic Programming - Memoization
        public static bool CheckValidStringExample2(string text)
        {
            int n = text.Length;
            int[,] memo = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    memo[i, j] = -1;
                }
            }
            return IsValidString(0, 0, text, memo);
        }

        private static bool IsValidString(int index, int openCount, string text, int[,] memo)
        {
            // If reached end of the string, check if all brackets are balanced
            if (index == text.Length)
            {
                return (openCount == 0);
            }

            // If already computed, return memoized result
            if (memo[index, openCount] != -1)
            {
                return memo[index, openCount] == 1;
            }

            bool isValid = false;

            // If encountering '*', try all possibilities
            if (text[index] == '*')
            {
                isValid |= IsValidString(index + 1, openCount + 1, text, memo); // Treat '*' as '('
                if (openCount > 0)
                {
                    isValid |= IsValidString(index + 1, openCount - 1, text, memo); // Treat '*' as ')'
                }
                isValid |= IsValidString(index + 1, openCount, text, memo); // Treat '*' as empty
            }
            else
            {
                // Handle '(' and ')'
                if (text[index] == '(')
                {
                    isValid = IsValidString(index + 1, openCount + 1, text, memo); // Increment count for '('
                }
                else if (openCount > 0)
                {
                    isValid = IsValidString(index + 1, openCount - 1, text, memo); // Decrement count for ')'
                }
            }

            // Memoize and return the result
            memo[index, openCount] = isValid ? 1 : 0;
            return isValid;
        }

        // Bottom-Up Dynamic Programming - Tabulation
        public static bool CheckValidStringExample3(string text)
        {
            int textLength = text.Length;

            // dp[i][j] represents if the substring starting from index i is valid with j opening brackets
            bool[,] dp = new bool[textLength + 1, textLength + 1];

            // base case: an empty string with 0 opening brackets is valid
            dp[textLength, 0] = true;

            for (int index = textLength - 1; index >= 0; index--)
            {
                for (int openBracket = 0; openBracket < textLength; openBracket++)
                {
                    bool isValid = false;

                    // '*' can represent '(' or ')' or '' (empty)
                    if (text[index] == '*')
                    {
                        isValid |= openBracket < textLength && dp[index + 1, openBracket + 1]; // try '*' as '('
                        
                        if (openBracket > 0)
                        {
                            isValid |= dp[index + 1, openBracket - 1]; // try '*' as ')'
                        }

                        isValid |= dp[index + 1, openBracket]; // ignore '*'
                    }
                    else
                    {
                        // If the character is not '*', it can be '(' or ')'
                        if (text[index] == '(')
                        {
                            isValid |= dp[index + 1, openBracket + 1]; // try '('
                        }
                        else if (openBracket > 0)
                        {
                            isValid |= dp[index + 1, openBracket - 1]; // try ')'
                        }
                    }

                    dp[index, openBracket] = isValid;
                }
            }

            return dp[0, 0]; // check if the entire string is valid with no excess opening brackets
        }

        // Two Pointer Approach;
        public static bool CheckValidStringExample4(string text)
        {
            int openCount = 0;
            int closeCount = 0;
            int length = text.Length - 1;

            // Traverse the string from both ends simultaneously
            for (int i = 0; i <= length; i++)
            {
                // Count open parentheses or asterisks
                if (text[i] == '(' || text[i] == '*')
                {
                    openCount++;
                }
                else
                {
                    openCount--;
                }

                // Count close parentheses or asterisks
                if (text[length - i] == ')' || text[length - i] == '*')
                {
                    closeCount++;
                }
                else
                {
                    closeCount--;
                }

                // If at any point open count or close count goes negative, the string is invalid
                if (openCount < 0 || closeCount < 0)
                {
                    return false;
                }
            }

            // If open count and close count are both non-negative, the string is valid
            return true;
        }

        // Greedy strategy;
        // 1. Initialize leftMin and leftMax to 0.
        // 2. Iterate through each character in the string s.
        // 3. If the character is '(', increment both leftMin and leftMax by 1.
        // 4. If the character is ')', decrement both leftMin and leftMax by 1.
        // 5. If the character is '*', decrement leftMin by 1 and increment leftMax by 1.
        // 6. If leftMax becomes negative at any point, return False since it means there are more closing parentheses than opening ones.
        // 7. If leftMin becomes negative, reset it to 0 since we can't have negative open parentheses count.
        // 8. After iterating through the string, check if leftMin is 0. If it is, return True; otherwise, return False.
        public static bool CheckValidStringExample5(string text)
        {
            int leftMin = 0, leftMax = 0;

            foreach (char c in text)
            {
                if (c == '(')
                {
                    leftMin++;
                    leftMax++;
                }
                else if (c == ')')
                {
                    leftMin--;
                    leftMax--;
                }
                else
                {
                    leftMin--;
                    leftMax++;
                }
                if (leftMax < 0) return false;
                if (leftMin < 0) leftMin = 0;
            }

            return leftMin == 0;
        }
    }
}