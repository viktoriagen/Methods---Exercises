﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var toBase = int.Parse(Console.ReadLine());

            var converted = IntegerToBase(number, toBase);
            Console.WriteLine(converted);
        }

         static string IntegerToBase(int number, int toBase)
        {
            var result = string.Empty;

            while (number > 0 )
            {
                
                var remainder = number % toBase;
                result = remainder + result;
                number /= toBase;
            }

            return result;
          
        }
    }
}
