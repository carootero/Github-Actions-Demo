using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QualityCheckDemo.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_1Plus2_Returns3()
        {
            int      result = Calculator.Add(1, 2);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Add_Minus1Plus1_Returns0()
        {
            int result = Calculator.Add(-1, 1);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Add_10Plus5_Returns15()
        {
            int result = Calculator.Add(10, 5);

            Assert.AreEqual(15, result);
        }
    }
}