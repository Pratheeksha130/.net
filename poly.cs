using System;

namespace Dlithe_CSharp
{
    internal class Polymorphism
    {
        static void Main(string[] args)
        {
            Overloading overloading = new Overloading();
            overloading.Add();
            overloading.Add(100);
            overloading.Add("John Doe");
            overloading.Add(1, "Peter");
            overloading.Add("Jane Doe", 2);
            overloading.Add(200);
            overloading.Add(3, "Paul");
            Console.ReadLine();
        }
    }

   
    internal class Overloading
    {
        public void Add()
        {
            Console.WriteLine("Method with no parameter");
        }

        public void Add(int a)
        {
            Console.WriteLine("Method with int parameter:" + a);
        }

        public void Add(string name)
        {
            Console.WriteLine("Method with string parameter:" + name);
        }

        public void Add(int id, string name)
        {
            Console.WriteLine("Method with int:" + id + ", string parameter:" + name);
        }

        public void Add(string ename, int eid)
        {
            Console.WriteLine("Method with string parameter:" + ename + ", int:" + eid);
        }
    }
}
