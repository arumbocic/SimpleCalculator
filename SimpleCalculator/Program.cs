using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter InputConverter = new InputConverter();
                CalculatorEngine CalculatorEngine = new CalculatorEngine();

                Console.WriteLine("Unesite prvi broj: ");
                double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());

                Console.WriteLine("Unesite drugi broj: ");
                double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());

                Console.WriteLine("Unesite operaciju: ");
                string operation = Console.ReadLine();

                double result = CalculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine("Rezultat: ");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
