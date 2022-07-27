using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter First Number  :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number  :");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("{0} + {1} = {2} ", a,b,c);
            int z = a - b;
            Console.WriteLine("{0} - {1} = {2} ", a, b, z);
            int x = a * b;
            Console.WriteLine("{0} * {1} = {2} ", a, b, x);
            int y = a / b;
            Console.WriteLine("{0} / {1} = {2} ", a, b, y);
            int w = a % b;
            Console.WriteLine("{0} % {1} = {2} ", a, b, w);
            
        }
    }
}
