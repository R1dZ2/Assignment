using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Calculation
    {

        Calculator calculator = new Calculator();

        public int PerformCalculation(int choice, int numberOne, int numberTwo)
        {
            CalculatorDelegate calculatorDelegate;
            switch (choice)
            {
                case 1:
                    calculatorDelegate = new CalculatorDelegate(calculator.Add);
                    break;

                case 2:
                    calculatorDelegate = new CalculatorDelegate(calculator.Subtract);
                    break;

                case 3:
                    calculatorDelegate = new CalculatorDelegate(calculator.Multiply);
                    break;

                default:
                    calculatorDelegate = new CalculatorDelegate(calculator.Add);
                    break;
            }
            return calculatorDelegate(numberOne, numberTwo);
        }
    }
}
