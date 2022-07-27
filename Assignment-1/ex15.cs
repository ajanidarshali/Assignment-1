using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atmiya university");
            Console.WriteLine(remove_char("Atmiya university",2));
            Console.WriteLine(remove_char("Atmiya university",8));
        }
        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}
