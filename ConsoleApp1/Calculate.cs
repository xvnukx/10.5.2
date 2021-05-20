using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Calculate : ICalculate
    {
        double a;
        double b;

        ILogger Logger { get; }

        public Calculate(ILogger logger)
        {
            Logger = logger;
        }

        void TryEnter()
        {
            try
            {
                Console.WriteLine("Введите число");
                this.a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите число");
                this.b = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine(Logger.Error("Введено неккоректное значение"));
                TryEnter();
            }
        }

        public string CalculateNumbers()
        {
            TryEnter();
            Console.WriteLine(Logger.Event("CalculateNumbers начал свою работу"));
            Thread.Sleep(1000);
            var sum = this.a + this.b;
            return $"{this.a} + {this.b} = {sum}\n{Logger.Event("CalculateNumbers закончил свою работу")}";
        }
    }
}
