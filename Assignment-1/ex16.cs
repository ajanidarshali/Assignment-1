using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e16
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("Enter String : ");
            str = Console.ReadLine();
            if (str.Length>= 1)
            {
                string a = str.Substring(0, 1);
                Console.WriteLine(a + str + a);
            }
        }
    }
}
