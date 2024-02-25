using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// You are given two non-empty linked lists representing two non-negative integers. 
    /// The digits are stored in reverse order, and each of their nodes contains a single digit. 
    /// Add the two numbers and return the sum as a linked list.
    /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    /// Input: l1 = [2,4,3], l2 = [5,6,4] Output: [7,0,8] Explanation: 342 + 465 = 807.
    /// </summary>
    public class LinkedList
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
        {
            if (l1 == null && l2 == null && carry == 0) return null;

            int total = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
            carry = total / 10;
            return new ListNode(total % 10, AddTwoNumbers(l1?.next, l2?.next, carry));
        }

        public ListNode ArrayToListNodes(int[] arr)
        {
            ListNode l = new ListNode();
            ListNode current = l;

            foreach (int i in arr)
            {
                current.next = new ListNode(i);
                current = current.next;
            }

            return l.next;
        }
    }
}
