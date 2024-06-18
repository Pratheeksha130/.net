﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_CSharp
{
    internal class Conditional
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Conditional Statements");
           

            Console.WriteLine("Greater of 2 numbers");
            int num1 = 500, num2 = 600, num3 = 70;
            
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Num1 is greater");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("Num2 is greater");
            }
            else
            {
                Console.WriteLine("Num3 is greater");
            }

            Console.WriteLine("Switch-Case");
            Console.WriteLine("enter the letter");
            char c = Convert.ToChar(Console.ReadLine());
            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("{0} is a Vowel", c);
                    break;

                default:
                    Console.WriteLine("{0} is Not a vowel", c);
                    break;

            }
            Console.ReadLine();
        }


    }
}