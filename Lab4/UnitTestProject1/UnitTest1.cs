using System;
using Lab4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {    

            
            //string one = Calculator.getNumberOne();
            //string two = Calculator.getNumberTwo();

            double d = Double.Parse("33");
            double dd = Double.Parse("10");

                Calculator.Divide(d,dd);

                Assert.IsNotNull("Cannot be null");
            //}
        }
    }
}
