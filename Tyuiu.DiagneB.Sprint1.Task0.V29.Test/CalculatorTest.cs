using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DiagneB.Sprint1.Task0.V29.Lib;
namespace Tyuiu.DiagneB.Sprint1.Task0.V29.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Test_CalculateExpression_Returns32()
        {
            Calculator calc = new Calculator();
            int expected = 32;
            int actual = calc.CalculateExpression();

            Assert.AreEqual(expected, actual, "Ошибка");
        }
    }
}
