using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Factorial_CSharp.Tests
{
    [TestClass]
    public class MyFactorialTest
    {
        [TestMethod]
        public void LoopMethodTestWithSpecificNumber()
        {
            // Arrange
            MyFactorial testValue = new MyFactorial(5);
            testValue.GetFactorialByLoop();
            long expected = testValue.ReturnValue;

            // Act 
            long act = 120;

            // Assert
            Assert.AreEqual(expected, act, message: $"{expected}");
        }

        [TestMethod]
        public void LoopMethodTessWithZero()
        {
            // Arrange
            MyFactorial testValue = new MyFactorial();
            testValue.GetFactorialByLoop();
            long expected = testValue.ReturnValue;

            // Act 
            long act = 1;

            // Assert
            Assert.AreEqual(expected, act, message: $"{expected}");
        }

        [TestMethod]
        public void RecursionMethodTestWithSpecificNumber()
        {
            // Arrange
            MyFactorial testValue = new MyFactorial();
            testValue.GetFactorialByRecursion();
            long expected = testValue.ReturnValue;

            // Act 
            long act = 1;

            // Assert
            Assert.AreEqual(expected, act, message: $"{expected}");
        }

        [TestMethod]
        public void RecursionMethodTestWithZero()
        {
            // Arrange
            MyFactorial testValue = new MyFactorial();
            testValue.GetFactorialByRecursion();
            long expected = testValue.ReturnValue;

            // Act 
            long act = 1;

            // Assert
            Assert.AreEqual(expected, act, message: $"{expected}");
        }
    }
}
