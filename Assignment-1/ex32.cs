using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String : ");
            string str = Console.ReadLine();
            Console.WriteLine(str.Length < 6 && str.Equals("H ello") || (str.StartsWith("Hello")));
        }
    }
}
