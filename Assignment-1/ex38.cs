using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e38
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[]{1, 1, 1, 2, 2, 3, 4, 5, 5, 4, 3, 2, 4};
            Console.Write("Enter Number  :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of " + a + " in array : ");
            Console.WriteLine(arr1.Count(n => n == a));
        }
    }
}
