using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromSortedListII
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public ListNode RemoveDuplicatesFromSortedListII(ListNode head)
        {
            List<int> distinct = new List<int>();
            var map = new Dictionary<int, int>();
            while (head != null)
            {
                if (!map.ContainsKey(head.val))
                    map.Add(head.val, 1);
                else
                    map[head.val]++;
                head = head.next;
            }
            foreach (var kvp in map.Where(x => x.Value == 1))
                distinct.Add(kvp.Key);
            ListNode res = null;
            for (int i = distinct.Count - 1; i >= 0; i--)
                res = new ListNode(distinct[i], res);
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
