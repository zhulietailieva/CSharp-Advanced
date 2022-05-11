using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp
{
    public class DoublyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void AddFirst(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Node prevHead = Head;
                Head = node;
                Head.Next = prevHead;
                prevHead.Previous = Head;
            }
        }
        public void AddLast(Node node)
        {
            if (Tail == null)
            {
                Tail = node;
                Head = node;
            }
            else
            {
                Node prevTail = Tail;
                Tail = node;
                Tail.Previous = prevTail;
                prevTail.Next = Tail;
            }
        }
        public int RemoveFirst()
        {
            if (Head == null)
            {
                return -1;
            }
            Node prevHead = Head;
            Head = Head.Next;
            Head.Next.Previous = null;

            return prevHead.Value;
        } 
        public int RemoveLast()
        {
            if (Tail == null)
            {
                return -1;
            }
            Node prevTail = Tail;
            Node newTail = Tail.Previous;
            newTail.Next = null;
            
            return prevTail.Value;
            
        }
        public void ForEach(Action<int> action)
        {
            Node n= this.Head;
            while (n != null)
            {
                action(n.Value);
                n = n.Next;

            }
        }
        public int[] ToArray()
        {
            List<int> doublyLinkedListToListInt = new List<int>();
            Node n = this.Head;
            while (n != null)
            {
                doublyLinkedListToListInt.Add(n.Value);
                n = n.Next;
            }
            return doublyLinkedListToListInt.ToArray();
        }

        }
   
}
