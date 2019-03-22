using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturnSumOfArgs()
        {
            // arrange
            var resultExpected = 10 + 8;

            // act
            var resultActual = new Math().Add(10, 8);

            // assert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [Test]
        public void Max_FirstGreater_ReturnFirstArg()
        {
            // arrange
            // act
            // assert
        }

        [Test]
        public void Max_SecondGreater_ReturnSecond()
        {

        }

        [Test]
        public void Max_FirstEqualSecond_ReturnFirst()
        {

        }
    }
}
