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
            Console.WriteLine(ans[0] + "" + ans[1]);
            return ans;
        }
    }
}
