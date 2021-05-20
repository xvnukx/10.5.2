using System;

namespace ConsoleApp1
{
    class Program
    {
        static ILogger Logger { get; set; }

        static void Main(string[] args)
        {
            Logger = new Logger();
            var calc = new Calculate(Logger);
            Console.WriteLine(calc.CalculateNumbers());
            
        }
    }
}
