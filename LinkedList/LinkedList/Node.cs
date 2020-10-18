using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{//constructor:
 // Takes object (data)and Node (reference to the next node in the list)

    //private fields:
    //object data- contains data of the node, what we want to store in list
    //node next- reference to the next node in the list

    //public properties:
    //Data- get/set the data field
    //Next- get/set the next field
    public class Node
    {
        
        private object data;
        private Node next;

        public Node(object data, Node next)
        {
            this.data = data;
            this.next = next;
}
        public object Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
