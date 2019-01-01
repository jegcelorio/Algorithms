using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {

      
        static void Main(string[] args)
        {

            LinkedList iList = new LinkedList();

            iList.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);
            Node fourth = new Node(4);
            
            iList.head.next = second;
            second.next = third;
            third.next = fourth;

       
            iList.InsertFront(6);


            iList.InsertBack(0);
            iList.PrintList();
            Console.ReadKey();

        }
    }
}
