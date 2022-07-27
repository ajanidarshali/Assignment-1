using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e42
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 8 };
            Console.WriteLine("Array Before Roting :[{0}] ", string.Join(", ", arr)); ;
            int new_arr = arr[0];
            for (int i = 0; i <arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = new_arr;
            Console.WriteLine("Array Before Roting :[{0}] ",string.Join(", ",arr));
        }
    }
}
