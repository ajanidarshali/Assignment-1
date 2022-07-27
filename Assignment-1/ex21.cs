using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e21
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Enter First Number : ");
            int a=Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(a - 100) <= 20 || Math.Abs(a - 200) <= 20)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
