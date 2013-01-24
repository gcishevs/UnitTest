using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Core;

namespace UnitTests.Tests.Core
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Check_Add_Without_Parameters()
        {
            Calculator calc = new Calculator();
            var actual = calc.Add();
            Assert.AreEqual(actual, 0);
        }
    }
}
