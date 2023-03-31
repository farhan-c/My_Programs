using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task_List
{
    class Stack_Demo
    {
        static public void Main()
        {
            Stack my_stack = new Stack();
            my_stack.Push("Hello");
            my_stack.Push("World");
            my_stack.Push("I am From");
            my_stack.Push("India");
            my_stack.Push(12);

            Console.WriteLine("Total elements present in" +
                        " my_stack: {0}", my_stack.Count);
            
            foreach (var item in my_stack)
            {
                Console.WriteLine(item);
            }
            my_stack.Pop();
            Console.WriteLine(my_stack.Pop());

            Console.WriteLine("Total elements present in " + "my_stack: {0}", my_stack.Count);
            

            my_stack.Clear();
            Console.WriteLine("Total elements present in " + "my_stack: {0}", my_stack.Count);
        }
    }
}
