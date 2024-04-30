using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingNodesInALinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public ListNode SwappingNodesInALinkedList(ListNode head, int k)
        {
            List<int> list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            int temp = list[k - 1];
            list[k - 1] = list[list.Count - k];
            list[list.Count - k] = temp;
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
