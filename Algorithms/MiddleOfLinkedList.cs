﻿/*
 * Middle of the Linked List
 *
 
Given the head of a singly linked list, return the middle node of the linked list.

If there are two middle nodes, return the second middle node.


Example 1:
Input: head = [1,2,3,4,5]
Output: [3,4,5]
Explanation: The middle node of the list is node 3.


Example 2:
Input: head = [1,2,3,4,5,6]
Output: [4,5,6]
Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.
 */

namespace Algorithms
{
    internal class MiddleOfLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast?.next != null)
            {
                slow = slow?.next;
                fast = fast.next?.next;
            }

            return slow;
        }

        public class ListNode
        {
            public ListNode next;
            public int val;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
