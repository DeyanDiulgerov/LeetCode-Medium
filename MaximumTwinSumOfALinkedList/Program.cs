using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumTwinSumOfALinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reverse Linked List into checking sums
        }
        public static int MaximumTwinSumOfALinkedList(ListNode head)
        {
            ListNode reversed = null;
            ListNode left = head;
            while(head != null)
            {
                reversed = new ListNode(head.val, reversed);
                head = head.next;
            }
            ListNode right = reversed;
            int max = 0;
            while(left != null)
            {
                max = Math.Max(max, left.val + right.val);
                left = left.next;
                right = right.next;
            }
            return max;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
