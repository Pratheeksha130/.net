using System;

namespace Dlithe_CSharp
{
    
    internal class Constructors : IDisposable
    {
        public int a;
        public int b;

       
        public Constructors()
        {
            a = 10;
            b = 10;
            Console.WriteLine("Default Constructor - Result:" + (a + b));
        }

        public Constructors(int x, int y)
        {
            Console.WriteLine("Parameterized Constructor - Result:" + (x + y));
        }

        
        ~Constructors()
        {
            Console.WriteLine("Destructor Invoked");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose Invoked");
        }

        static void Main(string[] args)
        {
            //Default constructor would be called automatically
            Constructors c = new Constructors();
            Constructors c1 = new Constructors(100, 200);
            c1.Dispose();
            Console.ReadLine();
        }
    }
}
