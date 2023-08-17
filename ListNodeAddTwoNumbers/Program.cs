using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNodeAddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static ListNode ListNodeAddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
        {
            if (l1 == null && l2 == null && carry == 0) return null;

            int total = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
            carry = total / 10;
            return new ListNode(total % 10, ListNodeAddTwoNumbers(l1?.next, l2?.next, carry));
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
