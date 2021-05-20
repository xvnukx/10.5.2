using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Logger : ILogger
    {
        public string Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return message;
        }

        public string Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            return message;
        }
    }
}
