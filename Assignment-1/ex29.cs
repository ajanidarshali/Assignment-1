using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 3, -5, 4 };
            int[] arr2 = new int[] { 1, 4, -5, -2 };
            Console.WriteLine("Multiplication of two array ");
            for (int i = 0; i <arr1.Length; i++)
            {
                Console.WriteLine(arr1[i] * arr2[i] + "");
            }
        }
    }
}
