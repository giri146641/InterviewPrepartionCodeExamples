using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Practise
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] ints = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[j])
                    {
                        ints[0] = i;
                        ints[1] = j;
                    }
                }
            }
            return ints;
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
        {
            if (l1 == null && l2 == null & carry == 0) return null;

            int total = l1.val + l2.val + carry;
            carry = total / 10;
            return new ListNode(total % 10, AddTwoNumbers(l1.next, l2.next, carry));
        }

        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> list = new HashSet<char>();

            int maxLength = 0;
            int end = 0;
            int start = 0;

            while (end < s.Length)
            {
                if (!list.Contains(s[end]))
                {
                    list.Add(s[end]);
                    maxLength = Math.Max(maxLength, end - start + 1);
                    end++;
                } else
                {
                    list.Remove(s[start]);
                    start++;
                }
            }
            return maxLength;
        }
    }
}