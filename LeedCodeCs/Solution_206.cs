using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    class Solution_206
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;

            while (head != null)
            {
                curr = head;
                head = head.next;
                curr.next = prev;
                prev = curr;
            }
            return curr;
        }


    }
}
