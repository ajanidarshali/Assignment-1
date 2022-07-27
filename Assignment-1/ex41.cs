using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e41
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine("Array1 : [{0}]", string.Join(", ", arr1));
            int[] arr2 = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            Console.WriteLine("Array1 : [{0}]", string.Join(", ", arr1));

            Console.WriteLine("1st and last Element is 1 or more ");
            Console.WriteLine((arr1[0].Equals(arr2[0])) || (arr1[arr1.Length-1].Equals(arr2[arr2.Length-1])));
        }
    }
}
