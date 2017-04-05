using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOne = int.Parse(Console.ReadLine());
            var numTwo = int.Parse(Console.ReadLine());
            var numThree = int.Parse(Console.ReadLine());
            var minNumber = GetMin( numOne, numTwo, numThree);
            Console.WriteLine(minNumber);
        }

         static int GetMin(int numOne,  int numTwo, int numTree)
        {
            if (numOne <= numTwo && numOne <= numTree)
            {
                return numOne;
            }
            else if (numTwo <= numOne && numTwo <= numTree)
            {
                return numTwo;
            }
            else
            {
                return numTree;
            }
        }
    }
}
