using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", a);
            Console.WriteLine("{0} {0}", a);
            Console.WriteLine("{0} {0}", a);
            Console.WriteLine("{0}{0}{0}", a);
        }
    }
}
