using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number (<100) :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number (>100):");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a < 100 && b > 100)
            {
                Console.WriteLine("First Number(<100) : {0}", a);
                Console.WriteLine("Second Number(>100) : {0}", b);
            }
        
        }
    }
}
