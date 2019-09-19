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
            long expected = testValue.GetFactorialByLoop();

            // Act 
            long act = 120;

            // Assert
            Assert.AreEqual(expected, act, message: $"{expected}");
        }

        [TestMethod]
        public void LoopMethodTest_1()
        {
            // Arrange
            MyFactorial testValue = new MyFactorial();
            long expected = testValue.GetFactorialByLoop();

            // Act 
            long act = 1;

            // Assert
            Assert.AreEqual(expected, act, message: $"{expected}");
        }

        [TestMethod]
        public void RecursionMethodTest_0()
        {
            // Arrange
            MyFactorial testValue = new MyFactorial();
            long expected = testValue.GetFactorialByRecursion(testValue.InputValue);

            // Act 
            long act = 1;

            // Assert
            Assert.AreEqual(expected, act, message: $"{expected}");
        }

        [TestMethod]
        public void RecursionMethodTest_1()
        {
            // Arrange
            MyFactorial testValue = new MyFactorial();
            long expected = testValue.GetFactorialByRecursion(testValue.InputValue);

            // Act 
            long act = 1;

            // Assert
            Assert.AreEqual(expected, act, message: $"{expected}");
        }
    }
}
