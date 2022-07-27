using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LinkedList
{
    public class ListNode<T>
    {
        public T Data { get; set; }
        public ListNode<T> Next { get; set; }

        public ListNode(T data)
        {
            Data = data;
        }
    }
}
