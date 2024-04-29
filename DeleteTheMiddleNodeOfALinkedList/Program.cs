using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteTheMiddleNodeOfALinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public ListNode DeleteTheMiddleNodeOfALinkedList(ListNode head)
        {
            List<int> list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            list.RemoveAt(list.Count / 2);
            ListNode res = null;
            for (int i = list.Count - 1; i >= 0; i--)
                res = new ListNode(list[i], res);
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
