using System;
using System.Collections.Generic;

namespace colas
{
    class Program
    {
        static void Main()
        {
            Stack<int> numeros = new Stack<int>();

            numeros.Push(1);
            numeros.Push(2);
            numeros.Push(3);

            Console.WriteLine(numeros.Pop());


            Queue<int> nums = new Queue<int>();

            nums.Enqueue(1);
            nums.Enqueue(2);
            nums.Enqueue(3);

            Console.WriteLine(nums.Dequeue());
        }
    }
}
