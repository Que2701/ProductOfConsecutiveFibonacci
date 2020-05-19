using FibonacciLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOfConsecutiveFibonacciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in ConsecutiveFibonacci.Product(714))
            {
                Console.Write($"{item} ");
            }

            // Allow the user to close the applicaiton
            Console.ReadLine();
        }
    }
}
