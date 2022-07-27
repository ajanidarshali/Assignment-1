using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((a < 0 && b > 0) || (a > 0 && b < 0));
            {
                Console.WriteLine("one is negative and one is positive ");
            }
        }
    }
}
