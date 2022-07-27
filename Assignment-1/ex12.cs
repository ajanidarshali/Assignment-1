using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write(a);
            Console.Write(" ");
            Console.Write(a);
            Console.Write(" ");
            Console.Write(a);
            Console.Write(" ");
            Console.Write(a);
            Console.WriteLine(" ");

            Console.Write(a);
            Console.Write(a);
            Console.Write(a);
            Console.Write(a);
            Console.WriteLine(" ");

            Console.WriteLine("{0} {0} {0} {0} ", a);
            Console.WriteLine("{0}{0}{0}{0}{0}", a);

        }
    }
}
