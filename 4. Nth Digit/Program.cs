using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var index = int.Parse(Console.ReadLine());
            var nthDigit = FindNthDigit(number, index);
            Console.WriteLine(nthDigit);
        }

         static int FindNthDigit(int number, int index)
        {
            for (int i = 1; i < index; i++)
            {
                number = number / 10;
            }
            int nthDigit = number % 10;
            return nthDigit;
        }
    }
}
