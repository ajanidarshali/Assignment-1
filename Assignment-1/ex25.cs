using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number ");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (a!=0)
            {
                a = a + sum;
                sum = a % 10;
                a = a / 10;
            }
            Console.WriteLine("Sum of the digit : "+sum);
        }
    }
}
