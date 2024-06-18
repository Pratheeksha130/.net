using System;
using System.Data; 

namespace Dlithe_CSharp
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to CSharp");
            Console.WriteLine("Test Data again");

            
            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine("Integer value:" + a);
            Console.WriteLine("Integer value:{0}", a);
            char b = 'A';
            Console.WriteLine(b);
            float f = 12.35f;
            Console.WriteLine(f);
            double d = 12.3654789652;
            Console.WriteLine(d);
            bool e = false;
            Console.WriteLine(e);
            Console.WriteLine("Float:{0}, Double:{1}", f, d);
            Console.WriteLine("Character:{0}, Boolean:{1}", b, e);

            //Give input during runtime
            Console.WriteLine("**********************");
            Console.WriteLine("Enter User Details");
            Console.WriteLine("Enter User Id");//10
            int userid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User ID is:{0}", userid);
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();
            Console.WriteLine("Username is:{0}", username);
            Console.ReadLine();
        }
    }
}
