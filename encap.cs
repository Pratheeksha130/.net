using System;

namespace Dlithe_CSharp
{
    
    internal class Encapsulation
    {
        
        static void Main(string[] args)
        {
            EncapsulationDemo demo = new EncapsulationDemo();
           
            demo.Id = 10;
            demo.Name = "John Doe";
            Console.WriteLine(demo.Id + ":" + demo.Name);
            Console.WriteLine(demo.Name);
            Console.ReadLine();

        }
    }

    internal class EncapsulationDemo
    {
        private int id;
        private string name;

        
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }

        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


    }
}
