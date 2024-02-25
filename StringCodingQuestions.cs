using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

namespace ConsoleApp1
{
    public class StringCodingQuestions
    {
        public static string example;

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
    }
}
