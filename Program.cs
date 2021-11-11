using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack and queues");
            //  StackAndQueue obj1 = new StackAndQueue();
            //  obj1.push(70);
            //   obj1.push(30);
            //   obj1.push(56);
            //   obj1.display();
            //  obj1.peak();
            //  obj1.pop();
            //  obj1.IsEmpty();
            // obj1.display();

            Queue obj1 = new Queue();
            obj1.Enqueue(56);
            obj1.Enqueue(30);
            obj1.Enqueue(70);
            obj1.display();
            obj1.Dequeue();
            obj1.display();

            Console.ReadLine();
        }
    }
}
