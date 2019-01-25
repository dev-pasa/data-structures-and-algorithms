using System;
using StacksAndQueues.Classes;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(null);
            Node node1 = new Node(1);
            stack.Push(node1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
                       
            Console.WriteLine(stack.Top.Value);
        }
    }
}
