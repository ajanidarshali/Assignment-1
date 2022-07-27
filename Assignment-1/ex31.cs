using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine(a % 3 == 0 || a % 7 == 0);
               // Console.WriteLine(a % 7==0);
            }
        }
    }
}
