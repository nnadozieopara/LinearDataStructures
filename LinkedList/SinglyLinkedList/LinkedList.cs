using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList.SinglyLinkedList;

namespace LinkedList.SinglyLinkedList
{
    public class LinkedList<T> : ICollection<T>
    {
        /// <summary>
        /// The first node in the list or null if empty
        /// </summary>
        public LinkedListNode<T> Head { get; private set; }

        /// <summary>
        /// The last node in the list or null if empty
        /// </summary>
        public LinkedListNode<T> Tail { get; private set; }
        /// <summary>
        /// Returns the number of items currently in the list
        /// </summary>
        public int Count { get; private set; } = 0;

        /// <summary>
        /// True if the collection is readonly, false otherwise.
        /// </summary>
        public bool IsReadOnly => false;

        /// <summary>
        /// adds an item to the tail of the LinkedList 
        /// </summary>
        /// <param name="item"> The value of the list of type 'T'</param>
        /// <returns>returns the linked list’s size</returns>
        public int AddItem(T item)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(item);
            return AddItem(node);
        }

        /// <summary>
        /// adds a node to the tail of the LinkedList 
        /// </summary>
        /// <param name="node">The node to be added to the tail of the list</param>
        /// <returns></returns>
        public int AddItem(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Tail = Head = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
            return Count++;
        }

        public void Clear()
        {
            Head = Tail = null;
            Count = 0;
        }

        /// <summary>
        /// Checks if an item is in the list
        /// </summary>
        /// <param name="item"></param>
        /// <returns>True if item is found and false otherwise</returns>
        public bool Contains(T item)
        {
            for (LinkedListNode<T> current = Head; current != null; current = current.Next)
            {
                if (item.Equals(current.Value))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// checks for a specified item in the linked list.
        /// </summary>
        /// <param name="item"> Returns a Boolean</param>
        /// <returns></returns>
        public bool Check(T item)
        {
            return Contains(item);
        }

        /// <summary>
        /// returns the index of an item or returns -1 if the item isn’t found
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Returns an integer</returns>
        public int IndexOf(T item)
        {
            int index = 0;
            for (LinkedListNode<T> current = Head; current != null; current = current.Next)
            {
                if (item.Equals(current.Value))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Enumerates over the linked list values from Head to Tail
        /// </summary>
        /// <returns>A Head to Tail enumerator</returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (LinkedListNode<T> current = Head; current != null; current = current.Next)
            {
                yield return current.Value;
            }
        }

        /// <summary>
        /// Removes the first item in the list and returns true if succesful or false otherwise
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Returns a boolean</returns>
        public bool RemoveFirst()
        {
            if (Count > 0)
            {
                if (Count == 1)
                {
                    Count--;
                    Head = Tail = null;
                    return true;
                }
                else
                {
                    LinkedListNode<T> temp = Head.Next;
                    Head.Next = null;
                    Head = temp;
                    Count--;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// removes the first occurrence of an item in the linked list, returns true if said item is found and removed or returns false otherwise
        /// </summary>
        /// <param name="item">item of type T to be removed</param>
        /// <returns>Returns a bool</returns>
        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            for (LinkedListNode<T> current = Head; current != null; current = current.Next)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                        Count--;
                        return true;
                    }
                    else
                    {
                        RemoveFirst();
                    }
                }
                previous = current;

            }
            return false;

        }
        /// <summary>
        /// Removes the last item in the list
        /// </summary>
        /// <returns>Returns a  true if it exists and false otherwise</returns>
        public bool RemoveLast()
        {
            if (Count == 0)
            {
                return false;
            }
            else if (Count == 1)
            {
                Head = Tail = null;
                Count = 0;
                return true;
            }
            else
            {
                for (LinkedListNode<T> current = Head; current != null; current = current.Next)
                {
                    LinkedListNode<T> temp = current.Next;
                    if (temp.Next == null)
                    {
                        Tail = current;
                        current.Next = null;
                        Count--;
                        return true;
                    }

                }
                return false;
            }

        }


        /// <summary>
        /// Adds item to the tail of the list
        /// </summary>
        /// <param name="item">item of type T to be added</param>
        void ICollection<T>.Add(T item)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(item);
            if (Count == 0)
            {
                Tail = Head = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns>A Head to Tail enumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Empty container");
            }
            else if (Count == 1)
            {
                T item = Head.Value;
                Head = Tail = null;
                Count = 0;
                return item;
            }
            else
            {
                for (LinkedListNode<T> current = Head; current != null; current = current.Next)
                {
                    LinkedListNode<T> temp = current.Next;
                    if (temp.Next == null)
                    {
                        T item = Tail.Value;
                        Tail = current;
                        current.Next = null;
                        Count--;
                        return item;
                    }

                }
                throw new InvalidOperationException("Invalid operation");
            }
        }

        public void Push(T item)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(item);
            if (Count == 0)
            {
                Tail = Head = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
            Count++;
        }
    }
}
