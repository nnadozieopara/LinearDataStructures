using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.SinglyLinkedList
{
    /// <summary>
    /// A node in the LinkedList
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedListNode<T>
    {
        /// <summary>
        /// The node value of type T
        /// </summary>
        public T Value { get; set; }
        /// <summary>
        /// Next: holds a pointer to the next node in the linkedlist
        /// </summary>
        public LinkedListNode<T> Next { get; set; }

        /// <summary>
        /// A constructor for creating instance of a the LinkedListNode
        /// </summary>
        /// <param name="value">The value of the node</param>
        /// <param name="next">a pointer to the next node</param>
        public LinkedListNode(T value, LinkedListNode<T> next)
        {
            Value = value;
            Next = next;
        }

        /// <summary>
        /// An overload of the LinkedList constructor with the specified value
        /// </summary>
        /// <param name="value"></param>
        public LinkedListNode(T value)
        {
            Value = value;
        }
    }
}
