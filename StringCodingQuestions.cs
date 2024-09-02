using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class StringCodingQuestions
    {
        public static string example;
        private static readonly Dictionary<char, string> phoneMap = new Dictionary<char, string>
        {
            {'2', "abc" },{'3', "def" },{'4', "ghi" },{'5', "jkl" },{'6', "mno" },{'7', "pqrs" },{'8', "tuv" },{'9', "xyz" }
        };

        public void Reverse()
        {
           string  reverse = ArrayReverse();
            int count = OccuranceString();
            Console.WriteLine(reverse);
            Console.WriteLine(count);
        }

        public static string Reversedwords()
        {
            example = "This is my book";

            List<string> words = new List<string>(example.Split(' '));
            words.Reverse();
            string a = string.Join(" ", words);
            return a;
        }
        
        public static string ArrayReverse()
        {
            example = "This is my book";
            string[] words = example.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        //Occurance of charcter using LINQ COUNT method
        public static int OccuranceString()
        {
            example = "This is my book";
            char find = 'i';

            int words = example.Count(x => char.ToLower(x) == char.ToLower(find));
            return words;
        }

        //Given a string s, find the length of the longest  substring without repeating characters.
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> charSet = new HashSet<char>();
            int maxLength = 0;
            int start = 0;
            int end = 0;

            while (end < s.Length)
            {
                if (!charSet.Contains(s[end]))
                {
                    charSet.Add(s[end]);
                    maxLength = Math.Max(maxLength, end - start + 1);
                    end++;
                }
                else
                {
                    charSet.Remove(s[start]);
                    start++;
                }
            }
            Console.WriteLine(maxLength.ToString());
            return maxLength;
        }

// 6. Zigzag Conversion
//The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
//P   A   H   N
//A P L S I I G
//Y   I   R
//And then read line by line: "PAHNAPLSIIGYIR"
        public string Convert(string s, int numRows)
        {
            // Edge case: If there's only one row, return the string as is
            if (numRows == 1) return s;

            // Create an array of StringBuilders, one for each row
            StringBuilder[] rows = new StringBuilder[Math.Min(numRows, s.Length)];
            for (int i = 0; i < rows.Length; i++)
            {
                rows[i] = new StringBuilder();
            }

            int currentRow = 0;
            bool goingDown = false;

            // Traverse the string
            foreach (char c in s)
            {
                // Append the current character to the corresponding row
                rows[currentRow].Append(c);

                // Change direction when you reach the top or bottom row
                if (currentRow == 0 || currentRow == numRows - 1)
                {
                    goingDown = !goingDown;
                }

                // Move up or down in the rows
                currentRow += goingDown ? 1 : -1;
            }

            // Combine all rows into a single string
            StringBuilder result = new StringBuilder();
            foreach (StringBuilder row in rows)
            {
                result.Append(row);
            }

            return result.ToString();
        }

//Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer.
//The algorithm for myAtoi(string s) is as follows:
//Whitespace: Ignore any leading whitespace(" ").
//Signedness: Determine the sign by checking if the next character is '-' or '+', assuming positivity is neither present.
//Conversion: Read the integer by skipping leading zeros until a non-digit character is encountered or the end of the string is reached.If no digits were read, then the result is 0.
//Rounding: If the integer is out of the 32-bit signed integer range [-231, 231 - 1], then round the integer to remain in the range. Specifically, integers less than -231 should be rounded to -231, and integers greater than 231 - 1 should be rounded to 231 - 1.
//Return the integer as the final result.
        public int MyAtoi(string s)
        {
            if(string.IsNullOrEmpty(s)) return 0;

            int i = 0;
            int n = s.Length;

            // For ignore leading spaces
            while (i < n && s[i] == ' ') {
                i++;
            }

            if (i >= n)
            {
                return 0;
            }

            int sign = 1;
            if (i < n && s[i] == '-' || s[i] == '+') {
                sign = (s[i] == '-') ? -1 : 1;
                i++;
            }

            int result = 0;
            while(i < n && char.IsDigit(s[i]))
            {
                int digit = s[i] - '0';
                if(result > (int.MaxValue - digit) / 10)
                {
                    return (sign == 1) ? int.MaxValue : int.MinValue;
                }

                result = result * 10 + digit;
                i++;
            }
            return result * sign;
        }

        //Regular Expression Matching
//Problem
//Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where:
//'.' Matches any single character.​​​​
//'*' Matches zero or more of the preceding element.
//The matching should cover the entire input string (not partial).
//Example 1:
//Input: s = "aa", p = "a"
//Output: false
//Explanation: "a" does not match the entire string "aa"

//### Explanation:
//1. **DP Table Initialization**: The `dp` table is initialized where `dp[i, j]` represents if the first `i` characters of `s` match the first `j` characters of `p`.
//We initialize the base case for an empty string and pattern.
//2. **Pattern Handling**: The code handles the `*` pattern by checking if it can match zero of the preceding elements(like "a*").
//3. **DP Table Population**: The table is filled based on:
//   - Direct match or match with `.`.
//   - Handling the `*` for both zero and multiple occurrences.
//4. **Final Result**: The result is stored in `dp[m, n]`, where `m` is the length of `s` and `n` is the length of `p`.

        public bool IsMatch(string s, string p)
        {
            int m = s.Length;
            int n = p.Length;

            // Create a DP table
            bool[,] dp = new bool[m + 1, n + 1];

            // Base case: empty string matches empty pattern
            dp[0, 0] = true;

            // Handle patterns like a*, a*b*, etc., which can match an empty string
            for (int j = 1; j <= n; j++)
            {
                if (p[j - 1] == '*')
                {
                    dp[0, j] = dp[0, j - 2];
                }
            }

            // Fill the DP table
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (p[j - 1] == '.' || p[j - 1] == s[i - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else if (p[j - 1] == '*')
                    {
                        // Case 1: * counts as zero of the preceding element
                        dp[i, j] = dp[i, j - 2];

                        // Case 2: * counts as one or more of the preceding element
                        if (p[j - 2] == '.' || p[j - 2] == s[i - 1])
                        {
                            dp[i, j] |= dp[i - 1, j];
                        }
                    }
                }
            }

            // The result will be in dp[m, n]
            return dp[m, n];
        }

//Example 1:
// Input: num = 3749
//Output: "MMMDCCXLIX"
//Explanation:
//3000 = MMM as 1000 (M) + 1000 (M) + 1000 (M)
// 700 = DCC as 500 (D) + 100 (C) + 100 (C)
//  40 = XL as 10 (X) less of 50 (L)
//   9 = IX as 1 (I) less of 10 (X)
//Note: 49 is not 1 (I) less of 50 (L) because the conversion is based on decimal places
        public string IntToRoman(int num)
        {
            var romanMap = new Dictionary<int, string> {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };

            var result = new StringBuilder();

            foreach (var kvp in romanMap)
            {
                while (num >= kvp.Key)
                {
                    result.Append(kvp.Value);
                    num -= kvp.Key;
                }
            }

            return result.ToString();
        }

        public int RomanToInt(string s)
        {
                var romanMap = new Dictionary<char, int> {
                    {'I', 1},
                    {'V', 5},
                    {'X',10},
                    {'L', 50},
                    {'C', 100},
                    {'D', 500 },
                    {'M', 1000 }
                };

                int result = 0;
                int n = s.Length;

                for (int i=0; i< n; i++)
                {
                    int currentValue = romanMap[s[i]];

                    if (i < n - 1 && romanMap[s[i+1]] > currentValue)
                    {
                        result -= currentValue;
                    } else
                    {
                        result += currentValue;
                    }
                }

                return result;
        }

//Write a function to find the longest common prefix string amongst an array of strings.
//If there is no common prefix, return an empty string "".
//Example 1:
//Input: strs = ["flower", "flow", "flight"]
//Output: "fl"
//Example 2:
//Input: strs = ["dog", "racecar", "car"]
//Output: ""
//Explanation: There is no common prefix among the input strings.
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    if (prefix == "") return "";
                }
            }
            return prefix;
        }

        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach(char c in s)
            {
                if(c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                } else
                {
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();
                    if(( c == ')' && top != '(' ) || (c == '}' && top != '{') ||
                        (c == ']' && top != '[')) { 
                    return false;}
                }
            }
            return stack.Count == 0;
        }

        //Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent.Return the answer in any order.
        //A mapping of digits to letters (just like on the telephone buttons) is given below.Note that 1 does not map to any letters.
        //        Example 1:
        //Input: digits = "23"
        //Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
        //        Example 2:
        //Input: digits = ""
        //Output: []
        //        Example 3:
        //Input: digits = "2"
        //Output: ["a","b","c"]
        public IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();

            if (string.IsNullOrEmpty(digits)) return result;
            //start the recursive backtracking process
            BackTrack(result, digits,0,"");
            return result;
        }

        private void BackTrack(List<string> result, string digits, int index, string currentCombination) {
            if(index == digits.Length)
            {
                result.Add(currentCombination);
                return;
            }

            string possibleLetters = phoneMap[digits[index]];
            foreach(var letter in possibleLetters)
            {
                BackTrack(result, digits, index+1, currentCombination+letter);
            }
        }
    }
}
