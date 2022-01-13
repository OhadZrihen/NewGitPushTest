using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IscCalc sciCalc = new SciCalc();
            double x = new Random().NextDouble() * 1000.0;
            double y = new Random().NextDouble() * 1000.0;
            PrintMathResult(sciCalc, x, y);

            IscCalc adapterCalc = new AdapterCalc();
            int xInt = new Random().Next(1000);
            int yInt = new Random().Next(1000);
            PrintMathResult(adapterCalc, xInt, yInt);

        }
        public static void PrintMathResult(IscCalc calc, double x,double y)
        {
            Console.WriteLine(calc.Add(x,y));
            Console.WriteLine(calc.Sub(x, y));
            Console.WriteLine(calc.Div(x, y));
            Console.WriteLine(calc.Mul(x, y));
        }
    }
}
