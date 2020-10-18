using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LinkedList
{ //Constructor:
  //LinkedList()- initializes the private fields

    //Private fields:
    //node head- reference to the first node in the list 
    //int size- the current size of our list

    //public properties:
    // empty- if the list is empty
    //count- how many itmes are in the list
    //indexer- access the data like an array

    //Methods:
    // Add (int index, object o)- takes int index, object, adds an item to list in the specified index
    // Add (object o)- takes object, adds an item to the end of the list
    //Remove (int index)- takes int index, removes the item in the list at specified index
    //Clear () - clears the list
    //IndexOf(object o) - gets the index of the item in the list, if not in list returns -1
    //Contains (object o) - true/false if the list contains the object
    //Get(int index)- gets the item at the specified index 

    public class LinkedList
    {
        private Node head;
        private int size;

        public LinkedList()
        {
            this.head = null;
            this.size = 0;
        }
        
        public bool Empty
        {
            get { return this.size == 0; }
        }
        public int Count
        {
            get { return this.size; }
        }
        // the add methods are busted and I dunno why or how to fix it
        public object Add (int index, object o) //what is wrong with this??(＃`Д´) "not all code paths return a value" 
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index:" + index);
            if (index > size)
                index = size;

            Node current = this.head;

            if (this.Empty || index==0)
            {
                this.head = new Node(o, this.head);
            }
            else
            {
                for (int i=0; i< index - 1; i++)
                {
                    current = current.Next;
                    current.Next = new Node(o, current.Next);
                }
                size++;

                return o;
            }

            public object Add (object o) // whyyy is it not valid? 
            {
                return this.Add(size, o);
            }

        }
    }
}
