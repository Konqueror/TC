using System;
using System.Collections.Generic;
using System.Linq;

namespace ADT_stack
{
    class Program
    {
        static void Main()
        {
            Stack<int> magicStack = new Stack<int>(2);

            magicStack.Push(1);
            magicStack.Push(2);
            magicStack.Push(3);
            magicStack.Push(4);
            magicStack.Push(5);
            magicStack.Push(6);

            Console.WriteLine(magicStack.Pop());
            Console.WriteLine(magicStack.Pop());

        }
    }
}
