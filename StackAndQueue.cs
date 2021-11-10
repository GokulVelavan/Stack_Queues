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

        internal void peak()  //peak the element from top
        {
            if (this.top == null)
            {
                Console.WriteLine("\n Stack is empty..");
                return;
            }
            Console.WriteLine("\n {0} is top of the stack. ", this.top.data); //dislay the top element
        }

        internal void pop()  //delete the element from the stack
        {
            if (this.top == null)
            {
                Console.WriteLine("\n Stack is Empty, Stack of top Not delete.");
                return;
            }
            Console.WriteLine("\n Data popped {0} in Stack of top. ", this.top.data); 
            this.top = this.top.next; 
        }
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                peak();
                pop();
            }
        }
    }
}
