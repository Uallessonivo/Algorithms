namespace Algorithms;

/*
 * Remove Nth Node From End of List
 *
 
Given the head of a linked list, remove the nth node from the end of the list and return its head.

 

Example 1:
Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]

Example 2:
Input: head = [1], n = 1
Output: []

Example 3:
Input: head = [1,2], n = 1
Output: [1]
 */

internal class RemoveNthNodeFromList
{
    public ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        var dummy = new ListNode(0)
        {
            next = head
        };

        var slow = dummy;
        var fast = dummy;

        for (var i = 0; i < n + 1; i++)
        {
            fast = fast?.next;
        }

        while (fast != null)
        {
            slow = slow?.next;
            fast = fast?.next;
        }

        if (slow != null) slow.next = slow?.next?.next;

        return dummy?.next;
    }

    public class ListNode
    {
        public ListNode? next;
        public int val;

        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}