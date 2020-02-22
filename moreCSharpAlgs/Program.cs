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
            void convertToF(int celsius)
            {
                var fahrenheit = 0;
                Console.WriteLine(fahrenheit = (celsius * 9) / 5 + 32);
            }

            convertToF(30);
        }
    }
}

//The algorithm to convert from Celsius to Fahrenheit is the temperature in Celsius times 9/5, plus 32.

//You are given a variable celsius representing a temperature in Celsius.Use the variable fahrenheit already defined and assign it the Fahrenheit temperature equivalent to the given Celsius temperature.Use the algorithm mentioned above to help convert the Celsius temperature to Fahrenheit.
