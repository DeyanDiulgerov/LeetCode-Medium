using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedListII
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public ListNode ReverseLinkedListII(ListNode head, int left, int right)
        {
            List<int> list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            Swap(list, left - 1, right - 1);
            ListNode res = null;
            for (int i = list.Count - 1; i >= 0; i--)
                res = new ListNode(list[i], res);
            return res;
        }
        public static void Swap(List<int> list, int left, int right)
        {
            while (left < right)
            {
                int temp = list[left];
                list[left] = list[right];
                list[right] = temp;
                left++;
                right--;
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
