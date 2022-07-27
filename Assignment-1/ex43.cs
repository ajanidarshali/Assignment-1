using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e43
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 5, 7, 8 };
            Console.WriteLine("Array : [{0}]",string.Join(", ",arr));
            int b = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>arr[0])
                {
                    b = arr[i];
                }
            }
            Console.WriteLine("Highest Number Between First and Last values : {0} ",b); 
        }
    }
}
