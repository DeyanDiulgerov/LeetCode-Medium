using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertGreatestCommonDivisorsInLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static ListNode InsertGreatestCommonDivisorsInLinkedList(ListNode head)
        {
            List<int> list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            for (int i = 0; i < list.Count - 1; i += 2)
            {
                int gcd = GetCommonDivisorForTwoNumbers(list[i], list[i + 1]);
                list.Insert(i + 1, gcd);
            }
            ListNode res = null;
            for (int i = list.Count - 1; i >= 0; i--)
                res = new ListNode(list[i], res);
            return res;
        }
        public static int GetCommonDivisorForTwoNumbers(int first, int second)
        {
            for (int i = Math.Min(first, second); i >= 1; i--)
            {
                if (first % i == 0 && second % i == 0)
                    return i;
            }
            return 1;
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
