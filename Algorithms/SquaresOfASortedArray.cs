﻿/* Squares of a Sorted Array

Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.


Example 1:

Input: nums = [-4,-1,0,3,10]
Output: [0,1,9,16,100]

Explanation: After squaring, the array becomes [16,1,0,9,100].
After sorting, it becomes [0,1,9,16,100].

Example 2:
Input: nums = [-7,-3,2,3,11]
Output: [4,9,9,49,121]

  */

namespace Algorithms
{
    public class SquaresOfASortedArraySolution
    {
        public static int[] SortedSquares(int[] nums)
        {
            var ordenedResult = new int[nums.Length];
            int left = 0, right = nums.Length - 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    ordenedResult[i] = nums[left] * nums[left];
                    left++;
                }
                else
                {
                    ordenedResult[i] = nums[right] * nums[right];
                    right--;
                }
            }

            return ordenedResult;
        }
    }
}
