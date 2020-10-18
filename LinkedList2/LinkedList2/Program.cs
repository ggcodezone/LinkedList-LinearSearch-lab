using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    //Demo of a linked list
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>(); //establish list
            myList.AddLast(5);//adding nodes
            myList.AddLast(3);
            myList.AddLast(7);
            myList.AddFirst(20);

            LinkedListNode<int> node = myList.Find(5); //find indicated node, then insert new node after it
            myList.AddAfter(node, 10);

            myList.RemoveFirst(); //this command remove first node from linked list

            Console.WriteLine("Count is:"+  myList.Count()); //gives you the number of elements in the linked list

            int Fount5 = myList.Count(s => s == 5);
            Console.WriteLine("5 is in index:" + Fount5); //find out the index position of an element

            foreach (var x in myList) //print out linked list
                Console.WriteLine(x);

            Console.ReadKey();

        }
    }
}
