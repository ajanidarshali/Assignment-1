using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _1e40
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{ 20, 30, 20, 10, 30, 50, 20, 25, 45, 10 };
            var sum = 0;
            Console.WriteLine("arr=[{0}]",string.Join(", ",arr));
            for (int i = 0; i <arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of Array : " + sum);
        }
    }
}
