using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortList
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public static ListNode SortList(ListNode head)
        {
            List<int> sorted = new List<int>();
            while (head != null)
            {
                sorted.Add(head.val);
                head = head.next;
            }
            sorted.Sort();
            sorted.Reverse();
            ListNode res = null;
            for (int i = 0; i < sorted.Count(); i++)
                res = new ListNode(sorted[i], res);
            return res;
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
