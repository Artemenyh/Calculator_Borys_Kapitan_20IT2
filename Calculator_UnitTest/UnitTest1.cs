using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection.Emit;

namespace Calculator_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestSum()
        {
            float a = 10;
            float b = 20;
            float expexted = 30;

            Class1 c = new Class1(a,b);
            float actual = c.sum();
            Assert.AreEqual(expexted, actual);
        }
        public void TestMinus()
        {
            float a = 9;
            float b = 3;
            float expexted = 6;

            Class1 c = new Class1(a, b);
            float actual = c.minus();
            Assert.AreEqual(expexted, actual);
        }
        public void TestMultiplicationt()
        {
            float a = 6;
            float b = 3;
            float expexted = 18;

            Class1 c = new Class1(a, b);
            float actual = c.multiplicationt();
            Assert.AreEqual(expexted, actual);
        }
        public void TestDivision()
        {
            float a = 8;
            float b = 4;
            float expexted = 2;

            Class1 c = new Class1(a, b);
            float actual = c.division();
            Assert.AreEqual(expexted, actual);
        }
    }
}
