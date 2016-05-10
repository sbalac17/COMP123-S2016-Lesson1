using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class HelloWorldUnitTest
    {
        [TestMethod]
        public void HelloWorldToConsoleTestMethod1()
        {
            //arrange
            string expectedResult = "Hello, World!";
            //act
            string result = COMP123_S2016_Lesson1.Program.HelloWorldToConsole();

            // assert 
            Assert.AreEqual(expectedResult, result);
        }
    }
}
