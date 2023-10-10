using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLibrary.Tests
{
    [TestClass()]
    public class CalculatorTests
    {

        [TestMethod()]
        public void CalculateTest()
        {
            //arrange
            IAdd add = new SubAdd();
            int firstNumber = 1;
            int secondNumber = 2;
            int expected = 3;
            int result;
            //act
            Calculator calculator = new Calculator(add);
            result = calculator.Calculate(firstNumber, secondNumber);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CalculateTest1()
        {
            Assert.AreEqual(1, 1);
            //throw new NotImplementedException();
        }
    }
}