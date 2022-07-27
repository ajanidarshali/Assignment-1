using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Age : ");
            int a = Convert.ToInt32(Console.ReadLine());

            int abs = Math.Abs(a);
           // Console.WriteLine(a);
            Console.WriteLine("you look older than {0}", abs);
        }
    }
}
