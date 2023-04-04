using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Rotate Array

Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.

 

Example 1:
Input: nums = [1,2,3,4,5,6,7], k = 3
Output: [5,6,7,1,2,3,4]

Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]


Example 2:
Input: nums = [-1,-100,3,99], k = 2
Output: [3,99,-1,-100]

Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]


Let the array be - 123456789 and k = 4

Step 1 - 12345 6789 ---> 54321 6789

Step 2 - 54321 6789 ---> 54321 9876

Step 3 - 543219876 ---> 678912345
  */

namespace Algorithms
{
    public class RotateArraySolution
    {
        public static int[] Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                result[(i + k) % n] = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = result[i];
            }

            return result;
        }
    }
}
