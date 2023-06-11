/*
 * Search Insert Position
 *


Given a sorted array of distinct integers and a target value, return the index if the target is found. 
If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

```
   Example 1:
   Input: nums = [1,3,5,6], target = 5
   Output: 2

   Example 2:
   Input: nums = [1,3,5,6], target = 2
   Output: 1

   Example 3:
   Input: nums = [1,3,5,6], target = 7
   Output: 4

   Example 4:
   Input: nums = [1,3,5,6], target = 0
   Output: 0
```
 */

namespace Algorithms
{
    public static class SearchInsertSolution
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1;
            int insertIndex = nums.Length;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (target == nums[mid])
                {
                    return mid; 
                }

                if (target < nums[mid])
                {
                    insertIndex = mid;
                    end = mid - 1;
                }
                else
                {
                    insertIndex = mid + 1;
                    start = mid + 1;
                }
            }

            return insertIndex;
        }
    }
}
