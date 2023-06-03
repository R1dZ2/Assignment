using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            var result = calculation.PerformCalculation(1, 2, 3);
            Console.WriteLine(result);
        }
    }
}
