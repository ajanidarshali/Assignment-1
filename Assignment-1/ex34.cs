using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number  :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number  :");
            int b = Convert.ToInt32(Console.ReadLine());
            if ((a<=10 && a>=-10 ) || (b<=10 && b>=-10))
            {
                Console.WriteLine("Given Number id between 10 to -10 ");
            }
        }
    }
}
