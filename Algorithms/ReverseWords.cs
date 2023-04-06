namespace Algorithms;

/*
 * Reverse Words in a String III
 *
 

Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

 
Example 1:
Input: s = "Let's take LeetCode contest"
Output: "s'teL ekat edoCteeL tsetnoc"


Example 2:
Input: s = "God Ding"
Output: "doG gniD"
 */

internal class ReverseWordsSolution
{
    public string ReverseWords(string s)
    {
        var splitted = s.Split(' ');

        for (int i = 0; i < splitted.Length; i++)
        {
           var word = splitted[i];
           var left = 0;
           var right = word.Length - 1;
           var wordChars = word.ToCharArray();

           while (left < right)
           {
               (wordChars[left], wordChars[right]) = (wordChars[right], wordChars[left]);
               left++;
               right--;
           }

           splitted[i] = new string(wordChars);
        }

        return string.Join(" ", splitted);
    }
}