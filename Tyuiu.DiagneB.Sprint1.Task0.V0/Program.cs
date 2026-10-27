using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DiagneB.Sprint1.Task0.V0.Lib;

//Задание
//Написать программу, которая вычисляет пыражение 10/ (2+3) и печатает результат на экране

namespace Tyuiu.DiagneB.Sprint1.Task0.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "спринт #1 | выполнил: Диагне Б. | ИБКСБ-26-1";
            //
            Console.WriteLine("*******************************************************************");



            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}
