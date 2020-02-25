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
            if(arr1.Length > arr2.Length)
            {
                IEnumerable<int> items = arr1.Except(arr2);
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                IEnumerable<int> items = arr2.Except(arr1);
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            } 
        }
        
        static void Main(string[] args)
        {
            Program p = new Program();

            p.diffArray(new int[] { 1, 2, 3, 5 }, new int[] { 1, 2, 3, 4, 5 });
        }
    }
}

//Compare two arrays and return a new array with any items only found in one of the two given arrays, but not both.In other words, return the symmetric difference of the two arrays.
