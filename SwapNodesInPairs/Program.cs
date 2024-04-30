using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNodesInPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public ListNode SwapNodesInPairs(ListNode head)
        {
            List<int> list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            SwapIn2Pairs(list, 0, 1);
            ListNode res = null;
            for (int i = list.Count - 1; i >= 0; i--)
                res = new ListNode(list[i], res);
            return res;
        }
        public static void SwapIn2Pairs(List<int> list, int left, int right)
        {
            while (right < list.Count)
            {
                int temp = list[left];
                list[left] = list[right];
                list[right] = temp;
                left += 2;
                right += 2;
            }
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
