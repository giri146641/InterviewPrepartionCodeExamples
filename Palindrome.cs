using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Palindrome
    {
        //Palindrome for number
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            int original = x;
            int reversed = 0;
            while (x > 0)
            {
                int digit = x % 10;
                reversed = reversed * 10 + digit;
                x /= 10;
            }

            return original == reversed;
        }
        //Given a string s, return the longest palindromic substring in s.
        //Example 1:
        //Input: s = "babad"
        //Output: "bab"
        //Explanation: "aba" is also a valid answer.
        //Example 2:
        //Input: s = "cbbd"
        //Output: "bb"
        public string LongestPalindrome(string s)
        {
            //Both start and maxLength keep track of longest palindorme so far
            int start = 0;
            int maxLength = 1;

            //The main idea is to expand around each charcter for Odd length Palindromes and  each pair
            //of charcters for even length palindromes .By expanding Outwards while the charcter the match
            //we can chcek if we have found palindrome.
            //The below function expand outwards from the given center and chcek if substring is palindrome.
            //It updates start and maxLength if a longer plaindrome is found.
            void ExpandAroundCenter(int left, int right)
            {
                while(left >= 0 && right < s.Length && s[left] == s[right]) { 
                    if(right - left + 1 > maxLength)
                    {
                        start = left;
                        maxLength = right - left + 1;
                    }
                    left--;
                    right++;
                }
            }

            //The code loops through each charcter and expand around it to find odd length palindromes
            //It is also expand b/w every two charcter to find even length palindromes.
            for(int i=0; i<s.Length; i++)
            {
                //odd length palindrome(single charcter center)
                ExpandAroundCenter(i, i);
                //even length palindrome(b/w two charcter center)
                ExpandAroundCenter(i,i+1);
            }

            //retrun the longest palindrome substring
            return s.Substring(start,maxLength);
        }
    }
}
