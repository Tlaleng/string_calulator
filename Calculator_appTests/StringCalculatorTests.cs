using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_app.Tests
{
    [TestClass()]
    public class StringCalculatorTests
    {

        [TestMethod()]
        public void calculateAdditionTest()
        {
            string expression = "1+1+1.5";
            double expected = 3.5;
            StringCalculator calculator = new StringCalculator();

            double actual = calculator.calculate(expression);
            Assert.AreEqual(expected, actual, "Addition test failed");
        }

        [TestMethod()]
        public void calculateSubtractionTest()
        {
            string expression = "1+1+1.5-7";
            double expected = 1 + 1 + 1.5 - 7;
            StringCalculator calculator = new StringCalculator();

            double actual = calculator.calculate(expression);
            Assert.AreEqual(expected, actual, "Subtraction test failed");
        }

        [TestMethod()]
        public void calculateDivisionTest()
        {
            string expression = "25/5/5";
            double expected = 25 / 5/5;
            StringCalculator calculator = new StringCalculator();

            double actual = calculator.calculate(expression);
            Assert.AreEqual(expected, actual, "Devision test failed");
        }

        [TestMethod()]
        public void calculateMultiplicationTest()
        {
            string expression = "5*5*5";
            double expected = 5 * 5 * 5;
            StringCalculator calculator = new StringCalculator();

            double actual = calculator.calculate(expression);
            Assert.AreEqual(expected, actual, "Multiplication test failed");
        }

        [TestMethod()]
        public void calculateMixedExpressionTest()
        {
            string expression = "12 * 2 + 12 / 2 - 2 * 3.5";
            double expected = 12 * 2 + 12 / 2 - 2 * 3.5;
            StringCalculator calculator = new StringCalculator();

            double actual = calculator.calculate(expression);
            Assert.AreEqual(expected, actual, "mixed expression test failed");
        }

        [TestMethod()]
        public void calculateExpressionFormatTest()
        {
            string expression = "12 * 2 + 12 / 2 - 2 * 3.5";
            double expected = 12 * 2 + 12 / 2 - 2 * 3.5;
            StringCalculator calculator = new StringCalculator();

            double actual = calculator.calculate(expression);
            Assert.AreEqual(expected, actual, "Expression Formatl test failed (spaces)");

            expression = "3.5";
            expected = 3.5;
            actual = calculator.calculate(expression);
            Assert.AreEqual(expected, actual, "Expression Formatl test failed (',' as decimal point)");

            expression = "3,5";
            expected = 3.5;
            actual = calculator.calculate(expression);
            Assert.AreEqual(expected, actual, "mixed expression test failed( '.' as decimal point)");
        }
    }
}