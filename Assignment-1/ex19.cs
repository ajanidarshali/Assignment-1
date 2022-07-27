using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e19
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Enter First Number : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int b=Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine((a - b) * 2);
            }
        }
    }
}
