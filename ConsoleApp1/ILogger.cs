using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ILogger
    {
        string Event(string message);
        string Error(string message);
    }
}
