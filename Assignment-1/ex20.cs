using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int b=Convert.ToInt32(Console.ReadLine());
            int c=a+b;
            if (a == 20 || b == 20 || c == 20)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
