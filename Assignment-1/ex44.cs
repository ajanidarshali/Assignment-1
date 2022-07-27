using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e44
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 =new int[] {  1, 2, 5};
            Console.WriteLine("Array1= [{0}]", string.Join(", ", arr1));
            int[] arr2 = {  0, 3, 8};
            Console.WriteLine("Array2= [{0}]", string.Join(", ", arr2));
            int[] arr3 = { -1, 0, 2 };
            Console.WriteLine("Array3= [{0}]", string.Join(", ", arr3));
            int[] new_array = { arr1[1], arr2[1], arr3[1] };
            Console.WriteLine("New Array : [{0}]",string.Join(", ",new_array));
        }
    }
}
