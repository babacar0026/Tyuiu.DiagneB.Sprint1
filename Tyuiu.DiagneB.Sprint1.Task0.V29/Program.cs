using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DiagneB.Sprint1.Task0.V29.Lib;



namespace Tyuiu.DiagneB.Sprint1.Task0.V29
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Вариант 29");
            Console.WriteLine("Задание: Вычислить выражение 2*9+7*2");
            Console.WriteLine("--------------------------------------------------");

            Calculator calc = new Calculator();
            int result = calc.CalculateExpression();
            Console.WriteLine($"Резултат: {result}");
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
