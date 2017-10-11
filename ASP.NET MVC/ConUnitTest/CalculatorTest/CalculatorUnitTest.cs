using ConUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
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

            Assert.AreEqual(expected, actual, 0.0001, "Addition not done properly");
        }
    }
}
