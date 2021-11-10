using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queues
{
    class StackAndQueue
    {

        private Node top;
        internal void push(int value) //program to push the data
        {
            Node node = new Node(value);  //new node is declared
            if (this.top == null)
            {
                node.next = null; //after data added next node  is declared to null
            }
            else
            {
                node.next = this.top;  //node pointing to the top of the stack
            }
            this.top = node;  //node to assigned to the top of stack
            Console.WriteLine(" {0} push to stack ", value);
        }

        internal void display()  //display the data
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " "); 
                temp = temp.next;
            }
        }
    }
}
