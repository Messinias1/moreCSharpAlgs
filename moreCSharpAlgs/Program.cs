using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreCSharpAlgs
{
    class Program
    {
        void diffArray(int[] arr1, int[] arr2)
        {
            var newArr = new List<int>();

            Console.WriteLine(arr2.Except(arr1));
        }
        
        static void Main(string[] args)
        {
            Program p = new Program();

            p.diffArray(new int[] { 1, 2, 3, 5 }, new int[] { 1, 2, 3, 4, 5 });
        }
    }
}

//Compare two arrays and return a new array with any items only found in one of the two given arrays, but not both.In other words, return the symmetric difference of the two arrays.
