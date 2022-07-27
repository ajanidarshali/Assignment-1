using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any String");
            String str = Console.ReadLine();
            if (str.Length > 4)
            {
                Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4) +
                    str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
            }

        }
    }
}
