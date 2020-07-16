using System;
using System.Collections.Generic;
using System.Text;

namespace simlpeStack
{
    class Stack
    {
        private readonly int[] stack;
        private int top;

        public Stack(int size)
        {
            stack = new int[size];
            top = 0;
        }

        public bool IsEmpty()
        {
            return top == 0;
        }

        public bool IsFull()
        {
            return top == stack.Length;
        }

        public void Push(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full!");
                return;
            }

            stack[top] = item;
            top++;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return 0;
            }

            top--;
            return stack[top];
        }

        public int Capasity()
        {
            return stack.Length;
        }
    }
}
