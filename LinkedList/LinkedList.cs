using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        public Node head; 

        public void PrintList()
        {
            Node n = head;
            while(n != null)
            {
                Console.Write(n.data);
                n = n.next;
               
            }
        }

        public void InsertFront(int data)
        {

            Node newNode = new Node(data);
            newNode.next = head;

            head = newNode;                   
        }

        public void InsertBack(int data) {
           
            Node newNode = new Node(data);
            
            if (head == null)
            {
                head = newNode;
                return;
            }

            newNode.next = null;

            Node n = head;
            while(n.next != null)
            {
                n = n.next;
            }

            n.next = newNode;
                       
        } 

    }
}
