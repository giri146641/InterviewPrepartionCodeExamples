using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //7. Reverse Integer
    //Given a signed 32-bit integer x, return x with its digits reversed.If reversing x causes the value to go outside the signed 32-bit integer range[-231, 231 - 1], then return 0.
    //Assume the environment does not allow you to store 64-bit integers(signed or unsigned)
    public class Integer
    {
        public int Reverse(int x)
        {
            if (x > int.MaxValue || x <= int.MinValue)
            {
                return 0;
            }
            int number = 0;
            while (x != 0)
            {
                if (Math.Abs(number) <= (int.MaxValue - Math.Abs(x) % 10) / 10)
                {
                    number = number * 10 + x % 10;
                    x /= 10;
                }
                else return 0;
            }
            return number;
        }

        //11. Container With Most Water
        //You are given an integer array height of length n.There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and(i, height[i]).
        //Find two lines that together with the x-axis form a container, such that the container contains the most water.
        //Return the maximum amount of water a container can store.
        //Notice that you may not slant the container.
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;

            while (left < right)
            {
                int currentArea = Math.Min(height[left], height[right]) * (right - left);
                maxArea = Math.Max(maxArea, currentArea);
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }

        //Given an integer array nums, return all the triplets[nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
        //Notice that the solution set must not contain duplicate triplets.
        //Example 1:
        //Input: nums = [-1, 0, 1, 2, -1, -4]
        //Output: [[-1,-1,2], [-1,0,1]]
        //Explanation: 
        //nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
        //nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
        //nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
        //The distinct triplets are[-1, 0, 1] and[-1, -1, 2].
        //Notice that the order of the output and the order of the triplets does not matter.
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums == null || nums.Length < 3) return result;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result;
        }

        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var result = new List<IList<int>>();
            if (nums == null || nums.Length < 4) return result;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;
                    int left = j + 1;
                    int right = nums.Length - 1;
                    while (left < right)
                    {
                        long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];

                        if (sum == target)
                        {
                            result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });

                            while (left < right && nums[left] == nums[left + 1]) left++;
                            while (left < right && nums[right] == nums[right - 1]) right--;

                            left++;
                            right--;
                        }
                        else if (sum < target)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }
            }

            return result;
        }

        //Given an integer array nums of length n and an integer target, find three integers in nums such that the sum is closest to target.
        //Return the sum of the three integers.
        //You may assume that each input would have exactly one solution.
        //Example 1:
        //Input: nums = [-1,2,1,-4], target = 1
        //Output: 2
        //Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int closestSum = nums[0] + nums[1] + nums[2];

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (Math.Abs(sum - target) < Math.Abs(closestSum - target))
                    {
                        closestSum = sum;
                    }

                    if (sum < target)
                    {
                        left++;
                    }
                    else if (sum > target)
                    {
                        right--;
                    }
                    else
                    {
                        return sum;
                    }
                }
            }

            return closestSum;
        }

        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();

            BackTrack(result, "", 0, 0, n);
            return result;
        }

        private void BackTrack(List<string> result, string current, int open, int close, int max)
        {
            if (current.Length == max * 2)
            {
                result.Add(current);
                return;
            }

            if(open < max)
            {
                BackTrack(result, current + "(", open+1, close, max);
            }

            if( close < open)
            {
                BackTrack(result, current + ")", open, close + 1, max);
            }
        }
    }
}
