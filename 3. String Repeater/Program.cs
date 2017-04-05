using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var repeater = int.Parse(Console.ReadLine());
            var resultString = RepeatString(str, repeater);
            Console.WriteLine(resultString);
        }

         static object RepeatString(string str, int repeater)
        {
            string repeatedString = string.Empty;
            for (int i = 0; i < repeater; i++)
            {
                repeatedString += str;
            }
            return repeatedString;
        }
    }
}
