using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreCSharpAlgs
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            void destroyer(int[] arr, params int[] list)
            {
                foreach(var num in list)
                {
                    Console.WriteLine(num);
                }
            }

            destroyer(new int[] { 1, 2, 3, 1, 2, 3 }, 2, 3);
            //   You will be provided with an initial array (the first argument in the destroyer function), followed by one or more arguments. Remove all elements from the initial array that are of the same value as these arguments.

            //   Note
            //   You have to use the arguments object.
        }
    }
}
