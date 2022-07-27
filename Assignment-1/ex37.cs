using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number  :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number  :");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 20;
            int x=Math.Abs(c-a);
            int y=Math.Abs(c-b);
            if (a == b)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (x < y)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}
