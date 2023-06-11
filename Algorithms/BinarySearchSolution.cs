/*
 * Binary Search
 *
Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. 
If target exists, then return its index. Otherwise, return -1.

You must write an algorithm with O(log n) runtime complexity.

 

```
Example 1:
   
   Input: nums = [-1,0,3,5,9,12], target = 9
   Output: 4
   Explanation: 9 exists in nums and its index is 4
   Example 2:
   
   Input: nums = [-1,0,3,5,9,12], target = 2
   Output: -1
   Explanation: 2 does not exist in nums so return -1
```
 */

namespace Algorithms
{
    public static class BinarySearchSolution
    {
        public static int Search(int[] nums, int target)
        {
            var low = 0;
            var high = nums.Length - 1;

            while (low <= high)
            {
                var mid = ( low + high ) / 2;

                if (target == nums[mid])
                {
                    return mid;
                }

                if (target > nums[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return - 1;
        }
    }
}
