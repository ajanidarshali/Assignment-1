using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            int z = Convert.ToInt32(Console.ReadLine());

            // int a=x+y.z;
             Console.WriteLine("{0},{1} and {2} , (x+y).z is {3}  (x.y)+(y.z) is {4}",x,y,z,((x+y)*z),(x*y+y*z));
        }
    }
}
