using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList.SinglyLinkedList;

namespace LinkedList.LinkedListStack
{
    public class Stack<T> : IEnumerable<T>
    {

        public SinglyLinkedList.LinkedList<T> store { get; set; } = new SinglyLinkedList.LinkedList<T>();
        /// <summary>
        /// This gives the number of items in the list
        /// </summary>
        public int Count => store.Count;

        public IEnumerator<T> GetEnumerator()
        {
            for (SinglyLinkedList.LinkedListNode<T> current = store.Head; current != null; current = current.Next)
            {
                yield return current.Value;
            }
        }

        /// <summary>
        /// removes and returns the last item added to the stack 
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            return store.Pop();
        }

        /// <summary>
        /// adds an item to the top of the stack 
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            store.Push(item);
        }

        /// <summary>
        /// returns true if the stack is empty and false is it isn’t 
        /// </summary>
        /// <returns>Returns a Boolean</returns>
        public bool IsEmpty()
        {
            if (store.Count == 0) return true;
            return false;
        }

        /// <summary>
        /// returns the last item added to the stack 
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            return store.Tail.Value;
        }

        /// <summary>
        /// shows the number of items currently in the stack 
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return store.Count;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
