using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;


// Name: Linked List
//Author: Gwen Kalasky
//: Synopsis: Creates linked list 
//Date: 10/13/20
namespace Node
{ 
    class Program
    {
        class LinkedListNode
        {
            public int data;
            public LinkedListNode next;

            public LinkedListNode(int x)
            {
                data = x;
                next = null;
            }
        }

        class LinkedList
        {
            int count;
            LinkedListNode head;

            public LinkedList()
            {
                head = null; //the head (i.e. front of list) pointer is set to null whenever you make a new linked list
                count = 0;
            }

            public void AddNodeToFront(int data) //adds node to front of list
            {
                LinkedListNode node = new LinkedListNode(data);
                node.next = head;
                head = node;
                count++;
            }

           public void PrintList() //prints out the list
            {
                LinkedListNode runner = head;
                while(runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next; //moves runner pointer thru whole list of data
                }
            }
        }
        static void Main(string[] args)
        {
            LinkedList MylinkedList = new LinkedList();
            LinkedList.AddNodeToFront(4);
            LinkedList.PrintList();
        }
        //(╯°□°)╯︵ ┻━┻ how to fix "an object reference is required for the non-static field"??
    }
}
