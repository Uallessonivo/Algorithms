namespace Algorithms;

/*
 * Move Zeroes
 *
 
Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

 

Example 1:
Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]


Example 2:
Input: nums = [0]
Output: [0]
 */

internal class MoveZeroesSolution
{
    public int[] MoveZeroes(int[] nums)
    {
        var n = nums.Length;
        var result = new int[n];
        var nonZeroIndex = 0;

        for (var i = 0; i < n; i++)
            if (nums[i] != 0)
            {
                if (i != nonZeroIndex) (nums[i], nums[nonZeroIndex]) = (nums[nonZeroIndex], nums[i]);
                nonZeroIndex++;
            }

        return result;
    }
}