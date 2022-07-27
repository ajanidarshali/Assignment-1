using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 6;
            Console.WriteLine("First Number : {0}",a);
            Console.WriteLine("Second Number : {0} ",b);
            Console.WriteLine("After Swapping : ");

            a = a*b;
            b = a/b;
            a = a / b;

            Console.WriteLine("First Number : {0}", a);
            Console.WriteLine("Second Number : {0} ", b);
        }
    }
}
