using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Factorial_CSharp.Tests
{
    [TestClass]
    public class MyFactorialTest
    {
        [TestMethod]
        public void LoopMethodTest_0()
        {
            // Arrange
            MyFactorial testValue = new MyFactorial(5);
            int expected = testValue.GetFactorialByLoop();

            // Act 
            int act = 120;

            // Assert
            Assert.AreEqual(expected, act, message: $"{expected}");
        }

        [TestMethod]
        public void LoopMethodTest_1()
        {
            // Arrange
            MyFactorial testValue = new MyFactorial();
            int expected = testValue.GetFactorialByLoop();

            // Act 
            int act = 1;

            // Assert
            Assert.AreEqual(expected, act, message: $"{expected}");
        }
    }
}
