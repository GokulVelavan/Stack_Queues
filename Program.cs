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
            StackAndQueue obj1 = new StackAndQueue();
            obj1.push(70);
            obj1.push(30);
            obj1.push(56);
            obj1.display();
            Console.ReadLine();
        }
    }
}
