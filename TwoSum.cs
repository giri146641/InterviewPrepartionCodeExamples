using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order.
    /// Input: nums = [2,7,11,15], target = 9 Output: [0,1]
    /// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    /// </summary>
    public class TwoSum
    {
        public int[] TwoSumofArray(int[] nums, int target)
        {
            int[] ans = new int[2];
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        ans[0] = i;
                        ans[1] = j;
                    }
                }
            }
            //Console.WriteLine(ans[0] + "" + ans[1]);
            return ans;
        }

        //Alertantive solution : Time Complexity o(n)
        //Need to store the value and respctive index using Dictonary later as you saw below code for loop go through all
        //array then first time it will caluclate actual target - first value of array then it will not found then it will stoare actual
        //array value in dictonray for the value 2 index is 0 once that done for the next time target is 9 and array value is 2
        //after sbstarction the value is since it already there in dictonary it will right value 7 index 1, so answer is [0,1]
        public int[] TwoSumofArrayList(int[] nums, int target)
        {
            var pairs = new Dictionary<int, int>();
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                if (pairs.ContainsKey(target - nums[i]))
                {
                    return new int[] { pairs[target - nums[i]] , i };
                } else
                {
                    pairs.Add(nums[i], i);
                }
            }
            return default;
        }
    }
}
