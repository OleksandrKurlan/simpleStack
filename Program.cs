using System;

namespace simlpeStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(10);

            Console.WriteLine(stack.Capasity());
            stack.IsEmpty();
            stack.Pop();
            for (int i = 0; i <= stack.Capasity(); i++)
            {
                stack.Push(i);
            }
            stack.IsFull();
            for (int i = 0; i < stack.Capasity(); i++)
            {
                Console.WriteLine(stack.Pop()); 
            }
            Console.ReadKey();
        }
    }
}
