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
        // My Way - 2nd Way
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            while (l1 != null)
            {
                list1.Add(l1.val.ToString());
                l1 = l1.next;
            }
            while (l2 != null)
            {
                list2.Add(l2.val.ToString());
                l2 = l2.next;
            }
            list1.Reverse();
            list2.Reverse();
            BigInteger res1 = BigInteger.Parse(String.Join("", list1));
            BigInteger res2 = BigInteger.Parse(String.Join("", list2));
            string str = ((BigInteger)(res1 + res2)).ToString();
            ListNode result = null;
            for (int i = 0; i < str.Length; i++)
            {
                result = new ListNode(str[i] - 48, result);
            }
            return result;
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
