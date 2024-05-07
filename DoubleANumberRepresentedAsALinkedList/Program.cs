using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DoubleANumberRepresentedAsALinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static ListNode DoubleANumberRepresentedAsALinkedList(ListNode head)
        {
            StringBuilder sb = new StringBuilder();
            while (head != null)
            {
                sb.Append(head.val);
                head = head.next;
            }
            BigInteger number = (BigInteger.Parse(sb.ToString()) * 2);
            string strNum = number.ToString();
            ListNode res = null;
            for (int i = strNum.Length - 1; i >= 0; i--)
                res = new ListNode(strNum[i] - 48, res);
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
