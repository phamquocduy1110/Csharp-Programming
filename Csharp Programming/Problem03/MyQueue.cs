using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class MyQueue
    {
        private int[] BufferQueue;
        private int front;
        private int rear;

        public MyQueue(int Size)
        {
            BufferQueue = new int[Size];
            front = 0;
            rear = -1;
        }

        public void Enqueue(int item)
        {
            BufferQueue[++rear] = item;
        }

        public int Dequeue()
        {
            return BufferQueue[front++];
        }

        public int Peek()
        {
            return BufferQueue[front];
        }

        public int Count()
        { 
            return rear + 1;
        }

        public void Clear()
        {
            rear = -1;
        }
    }
}
