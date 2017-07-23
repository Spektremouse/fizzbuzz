using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void When_NotMultipleOf3_Expect_IsFizzAsFalse()
        {
            //Arrange   
            var fb = new FizzBuzzer();
            fb.FizzMultiple = 3;
            const int expected = 8;
            //Act
            bool result = fb.IsFizz(expected);
            //Assert
            Assert.AreEqual(false, result);         
        }

        [TestMethod]
        public void When_MultipleOf3_Expect_IsFizzAsTrue()
        {
            //Arrange   
            var fb = new FizzBuzzer();
            fb.FizzMultiple = 3;
            const int expected = 9;
            //Act
            bool result = fb.IsFizz(expected);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void When_MultipleOf5_Expect_IsBuzzAsTrue()
        {
            //Arrange   
            var fb = new FizzBuzzer();
            fb.BuzzMultiple = 5;
            const int expected = 10;
            //Act
            bool result = fb.IsBuzz(expected);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void When_NotMultipleOf5_Expect_IsBuzzAsFalse()
        {
            //Arrange   
            var fb = new FizzBuzzer();
            fb.BuzzMultiple = 5;
            const int expected = 11;
            //Act
            bool result = fb.IsBuzz(expected);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Should_ResetVariables_ToDefaultValues()
        {
            //Arrange   
            var fb = new FizzBuzzer();
            fb.FizzMultiple = 9;
            fb.BuzzMultiple = 10;
            fb.Length = 1220;
            const int expectedFizzMultiple = 3;
            const int expectedBuzzMultiple = 5;
            const int expectedLength = 100;
            //Act
            fb.Reset();
            //Assert
            Assert.AreEqual(expectedFizzMultiple, fb.FizzMultiple);
            Assert.AreEqual(expectedBuzzMultiple, fb.BuzzMultiple);
            Assert.AreEqual(expectedLength, fb.Length);
        }

        [TestMethod]
        public void Should_GetAndSet_Length()
        {
            //Arrange
            int expected = new Random().Next();
            //Act
            var fb = new FizzBuzzer() { Length = expected };
            //Assert
            Assert.AreEqual(expected, fb.Length);
        }

        [TestMethod]
        public void Should_GetAndSet_FizzMultiple()
        {
            //Arrange
            int expected = new Random().Next();
            //Act
            var fb = new FizzBuzzer() { FizzMultiple = expected };
            //Assert
            Assert.AreEqual(expected, fb.FizzMultiple);
        }

        [TestMethod]
        public void Should_GetAndSet_BuzzMultiple()
        {
            //Arrange
            int expected = new Random().Next();
            //Act
            var fb = new FizzBuzzer() { BuzzMultiple = expected };
            //Assert
            Assert.AreEqual(expected, fb.BuzzMultiple);
        }
    }
}
