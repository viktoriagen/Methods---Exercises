using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var result = Console.ReadLine();

                if (result == "positive")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    string resultMessage = ShowSuccess(operation,  message);
                }

            }
        }

         static string ShowSuccess(string operation, string message)
        {
            string textToprint = string.Format($"Successfully executed {operation}.\n==============================\nMessage: {message}.");
            return textToprint;
        }
    }
}
