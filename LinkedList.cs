using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

//Given the head of a linked list, remove the nth node from the end of the list and return its head.
//        Input: head = [1,2,3,4,5], n = 2
//Output: [1,2,3,5]
//        Example 2:
//Input: head = [1], n = 1
//Output: []
//        Example 3:
//Input: head = [1,2], n = 1
//Output: [1]
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode();
            dummy.next = head;
            ListNode first = dummy;
            ListNode second = dummy;

            for( int i=0; i <= n; i++ )
            {
                first = first.next;
            }

            while(first != null){
                first = first.next;
                second = second.next;
            }
            second.next = second.next.next;
            return dummy.next;
        }

        //You are given the heads of two sorted linked lists list1 and list2.
        //Merge the two lists into one sorted list.The list should be made by splicing together the nodes of the first two lists.
        //Return the head of the merged linked list.
        //Input: list1 = [1,2,4], list2 = [1,3,4]
        //Output: [1,1,2,3,4,4]
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode listNode = new ListNode();
            ListNode tail = listNode;

            while(list1  != null && list2 != null) {
                if(list1.val <= list2.val)
                {
                    tail.next = list1;
                    list1 = list1.next;
                } else
                {
                    tail.next = list2;
                    list2 = list2.next;
                }

                tail = tail.next;
            }

            if(list1 != null)
            {
                tail.next = list1;
            }

            if(list2 != null)
            {
                tail.next = list2;
            }
             return listNode.next;
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
