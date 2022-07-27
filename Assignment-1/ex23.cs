using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("odd Number from 1 to 99 ");
            for (int i = 1; i <= 99; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
    }
}
