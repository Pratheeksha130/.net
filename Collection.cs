using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_CSharp
{
   
    internal class Collections
    {
        static void Main(string[] args)
        {
            ArrayListDemo();
            ListDemo();
            StackDemo();
            QueueDemo();
            LinkedListDemo();
            Console.ReadLine();

        }

        
        public static void ArrayListDemo()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("John");
            arrayList.Add(false);
            arrayList.Add(123.45);
            Console.WriteLine("********ARRAYLIST DEMO**********");
            foreach (object i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("******************");
            arrayList.Reverse();
            foreach (object i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("******************");
            arrayList.Remove(1);
            foreach (object i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("******************");
            arrayList.RemoveAt(0);
            foreach (object i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("******************");
            arrayList.Insert(2, "Hello");
            foreach (object i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("******************");
            int index = arrayList.IndexOf("Hello");
            Console.WriteLine(index);

        }

        
        public static void ListDemo()
        {
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            Console.WriteLine("********LIST DEMO**********");
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }

        
       

        
        public static void StackDemo()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine("********STACK DEMO**********");
            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }
            stack.Pop();
            Console.WriteLine("******************");
            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("******************");
            Console.WriteLine(stack.Peek());
        }

        
        public static void QueueDemo()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine("********QUEUE DEMO**********");
            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }
            queue.Dequeue();
            Console.WriteLine("******************");
            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("******************");
            Console.WriteLine(queue.Peek());
        }

        public static void LinkedListDemo()
        {
            LinkedList<int> linkedlist = new LinkedList<int>();
            linkedlist.AddLast(1);
            linkedlist.AddLast(2);
            linkedlist.AddLast(3);
            linkedlist.AddFirst(10);
            linkedlist.AddFirst(9);
            Console.WriteLine("********LINKEDLIST DEMO**********");
            foreach (var i in linkedlist)
            {
                Console.WriteLine(i);
            }

        }
    }
}