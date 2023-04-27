using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestArrayCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestArrayCalculator.Tests
{
    [TestClass()]
    public class ArrayCalculatorTests
    {
        [TestMethod()]
        public void SumTest()
        {
            double[] array = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            double result = ArrayCalculator.Sum(array);
            Assert.AreEqual(15.0, result);
        }

        [TestMethod()]
        public void AverageTest()
        {
  
            double[] array = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            double result = ArrayCalculator.Average(array);
            Assert.AreEqual(3.0, result);
        }

        [TestMethod()]
        public void MinTest()
        {

            double[] array = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            double result = ArrayCalculator.Min(array);
            Assert.AreEqual(1.0, result);
        }

        [TestMethod()]
        public void MaxTest()
        {
  
            double[] array = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            double result = ArrayCalculator.Max(array);
            Assert.AreEqual(5.0, result);
        }
    }
}