using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateListLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static ListNode RotateListLinkedList(ListNode head, int k)
        {
            if (head == null)
                return head;
            List<int> list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            int n = list.Count;
            k %= n;
            Swap(list, 0, n - 1);
            Swap(list, 0, k - 1);
            Swap(list, k, n - 1);
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
