using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConUnitTest;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num1 = 100;
            int num2 = 50;
            int expected = 150;

            Calculator calc = new Calculator();
            int actual = calc.Add(num1, num2);

            Assert.AreEqual(expected, actual, "Addition not done properly");
        }

        [TestMethod]
        public void TestMethod2()
        {
            int num1 = 100;
            int num2 = 50;
            int expected = 50;

            Calculator calc = new Calculator();
            int actual = calc.Sub(num1, num2);

            Assert.AreEqual(expected, actual, 0.0001, "Sub not done properly");
        }

        [TestMethod]
        public void TestMethod3()
        {
            int num1 = 100;
            int num2 = 50;
            int expected = 5000;

            Calculator calc = new Calculator();
            int actual = calc.Mul(num1, num2);

            Assert.AreEqual(expected, actual, 0.0001, "Mul not done properly");
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMethod4()
        {
            int num1 = 100;
            int num2 = 0;
            int expected = 2;

            Calculator calc = new Calculator();
            int actual = calc.Div(num1, num2);

            Assert.AreEqual(expected, actual, 0.0001, "Div not done properly");
        }
    }
}
