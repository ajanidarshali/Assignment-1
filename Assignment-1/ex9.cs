using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Four Number : ");
            int d = Convert.ToInt32(Console.ReadLine());

            int z = a + b + c + d;
            Console.WriteLine("sum {0} : ",z);

            int avg = z/4;
            Console.WriteLine("The Average of {0},{1},{2},{4} is {5}", a,b,c,d,z,avg);
           // Console.WriteLine(avg);
        }
    }
}
