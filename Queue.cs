using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queues
{
    class Queue
    {
        Node head = null;//delaring the head node to null
        internal void Enqueue(int data) //program to add data
        {
            Node node = new Node(data);//creating a node with data

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Queue", node.data);
        }

        internal void Dequeue() //deleting element from begining
        {

            if (this.head == null)
            {
                Console.WriteLine("no elements present ");
                return;
            }
            else
            {

                    Node temp = head;
                while (this.head != null)
                {
                  Console.WriteLine( temp.data);//diplaying node data
                    this.head = this.head.next;
                    temp = head;
                }
            }
        }
        internal void display()  //display the elements
        {
            Node temp = this.head;
            if (temp == null) 
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null) 
            {
                Console.WriteLine(temp.data + " "); //diplaying the data untill end.
                temp = temp.next;
            }
        }
    }
}
