using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
}
