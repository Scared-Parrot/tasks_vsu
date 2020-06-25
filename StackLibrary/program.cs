using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack <int> stack = new ArrayStack <int>();
            stack.Push(57);
            stack.Push(789);
            stack.Push(456);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.Read();
        }
    }
}
