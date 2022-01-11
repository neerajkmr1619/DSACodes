using System;

namespace Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            /*LinkList ll = new LinkList();
            ll.insertFirst(val :4);
            ll.insertFirst(val :3);
            ll.insertLast(val: 7);
            ll.insertLast(val: 13);
            ll.insert(100,2);
            ll.display();
            Console.WriteLine("\n" +ll.deleteFirst());
            ll.display();
            Console.WriteLine("\n" +ll.deleteLast());
            ll.display();
            Console.WriteLine("\n" +ll.delete(1));
            ll.display();
            Console.WriteLine("\n" +ll.findNode(4).value);*/

            DLL dll = new DLL();
            dll.insertFirst(4);
            dll.insertFirst(3);
            dll.insertFirst(5);
            dll.insertFirst(9);
            dll.insertLast(19);
            dll.display();
            dll.insertAfterValue(5,17);
            Console.WriteLine();
            dll.display();
            
        }
    }
}
