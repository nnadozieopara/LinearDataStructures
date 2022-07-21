using LinkedList.LinkedListStack;
using LinkedList.Queue;
using LinkedList.SinglyLinkedList;
using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList
            Console.WriteLine("Hello World!");
            LinkedList<int> list = new LinkedList<int>();
            list.AddItem(1);
            list.AddItem(2);
            list.AddItem(3);
            list.AddItem(4);
            list.RemoveLast();
            list.Remove(3);
            int val = list.Pop();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Stack
            Stack<int> stack = new Stack<int>();
            stack.Push(9);
            stack.Push(10);
            stack.Push(11);
            int ans = stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(11);
            int size = queue.Size();
            queue.Dequeue(); 
            #endregion
        }
    }
}
