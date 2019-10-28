using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue theQueue = new MyQueue(3);
            Console.Write("Enter the number of items: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[n];

            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write("Input Item {0}:", i);
                theQueue.Enqueue(Arr[i] = int.Parse(Console.ReadLine()));
            }

            int value = theQueue.Dequeue();
            Console.WriteLine("Value of Dequeue: {0}", value);

            int value1 = theQueue.Peek();
            Console.WriteLine("Value of Peek: {0}", value1);

            int value2 = theQueue.Count();
            Console.WriteLine("Value of Count: {0}", value2);
        }
    }
}
