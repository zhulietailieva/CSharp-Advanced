using System;

namespace StartUp
{
    public class Test
    {
        static void Main(string[] args)
        {
            DoublyLinkedList L = new DoublyLinkedList();
            L.AddFirst(new Node(3));
            L.AddFirst(new Node(2));
            L.AddFirst(new Node(1));
            L.AddLast(new Node(4));
            L.AddLast(new Node(5));
            //L.AddFirst(new Node(6));
            //Console.WriteLine("Removed First: "+L.RemoveFirst());
            //Console.WriteLine($"Removed Last: {L.RemoveLast()}");


            L.ForEach(x =>
            {
                Console.WriteLine("In Action");
                Console.WriteLine(x);
            });

            Node n = L.Head;
            while (n != null)
            {
                Console.WriteLine(n.Value);
                n = n.Next;
            }
            DoublyLinkedList L1 = new DoublyLinkedList();
            Console.WriteLine(L1.RemoveFirst());
            Console.WriteLine(string.Join("-",L.ToArray()));
        }
    }
}
