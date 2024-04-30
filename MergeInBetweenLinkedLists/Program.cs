using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeInBetweenLinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public ListNode MergeInBetweenLinkedLists(ListNode list1, int a, int b, ListNode list2)
        {
            List<int> listOne = new List<int>();
            while (list1 != null)
            {
                listOne.Add(list1.val);
                list1 = list1.next;
            }
            var listTwo = new List<int>();
            while (list2 != null)
            {
                listTwo.Add(list2.val);
                list2 = list2.next;
            }
            listOne.RemoveRange(a, b - a + 1);
            listOne.InsertRange(a, listTwo);
            ListNode res = null;
            for (int i = listOne.Count - 1; i >= 0; i--)
                res = new ListNode(listOne[i], res);
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
