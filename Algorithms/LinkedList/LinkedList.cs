using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LinkedList
{
    public class LinkedList<T>
    {
        public ListNode<T> Head { get; private set; }

        public void PrependNode(T data)
        {
            var prev = new ListNode<T>(data);
            prev.Next = Head;
            Head = prev;
        }

        public void AppendNode(T data)
        {
            var next = new ListNode<T>(data);

            if (Head == null)
            {
                Head = next;
                return;
            }

            var current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = next;
        }

        public void Reverse()
        {
            ListNode<T> prev = null;
            var current = Head;

            // 1 -> 2 -> 3 -> null
            // null <- 1 <- 2 <- 3

            while (current != null)
            {
                var next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            Head = prev;
        }
    }
}
