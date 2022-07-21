using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Queue
{
    public class Queue<T>:IEnumerable<T>
    {
        public SinglyLinkedList.LinkedList<T> Store { get; set; } = new SinglyLinkedList.LinkedList<T>();
        /// <summary>
        /// returns true if the queue is empty and false is it isn’t 
        /// </summary>
        /// <returns>Returns a boolean</returns>
        public bool IsEmpty()
        {
            if (Store.Count == 0) return true;
            return false;
        }

        /// <summary>
        /// shows the number of items currently in the queue 
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return Store.Count;
        }

        /// <summary>
        /// adds an item to the tail of the queue 
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(T item)
        {
            Store.AddItem(item);
        }

        /// <summary>
        /// removes and returns the item at the head of the queue 
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            T item = Store.Head.Value;
            Store.RemoveFirst();
            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
