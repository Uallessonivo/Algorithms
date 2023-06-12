/*

Find the Index of the First Occurrence in a String

Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

 

Example 1:

Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: "sad" occurs at index 0 and 6.
The first occurrence is at index 0, so we return 0.


Example 2:

Input: haystack = "leetcode", needle = "leeto"
Output: -1
Explanation: "leeto" did not occur in "leetcode", so we return -1.
 */

namespace Algorithms
{
    internal class IndexFirstOccurrenceString
    {
        public int StrStr(string haystack, string needle)
        {
            var m = needle.Length;
            var n = haystack.Length;

            for (int window_start = 0; window_start <= n - m; window_start++)
            {
                for (int i = 0; i < m; i++)
                {
                    if (needle[i] != haystack[window_start + i])
                    {
                        break;
                    }
                    if (i == m - 1)
                    {
                        return window_start;
                    }
                }
            }

            return -1;
        }
    }
}
