using System;
using BasicMath;
using NUnit.Framework;

namespace BasicMathTest
{
 
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Test_AddMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }

        [Test]
        public void Test_SubstractMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Substract(10, 10);
            Assert.AreEqual(res, 0);
        }

        [Test]
        public void Test_DivideMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.divide(10, 5);
            Assert.AreEqual(res, 2);
        }

        [Test]
        public void Test_MultiplyMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
    }
}
