using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public class Stack
    {
        string[] Buffer;
        int Top;
      
        public Stack(int size)
        {
            Buffer = new string[size];
            Top = -1;
        }

        
        //public Stack()
        //{
        //Buffer = new string[1000];
        //}

        public void Push(string value)
        {
            Buffer[Top + 1] = value;
            Top = Top + 1;
        }

        public string Pop()
        {
            string value = Buffer[Top];
            Top = Top - 1;
            return value;
            //int result = 0;
            //result= Buffer[top];
            //top--;
            //return result;
        }

        public string Peek()
        {
            return Buffer[Top];
        }

        public int Count()
        {
            return Top + 1;
        }

        public void Clear()
        {
            Top = -1;
        }
    }
}
