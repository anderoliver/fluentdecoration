using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FluentDecoration.Tests
{
    [TestClass]
    public class BooleanExtensionsTest
    {
        [TestMethod]
        public void ShouldTestAndExpression()
        {
            bool iHaveEgg, iHaveMilk;

            iHaveEgg = true; iHaveMilk = true;
            Assert.IsTrue(iHaveEgg.And(iHaveMilk));

            iHaveEgg = false; iHaveMilk = true;
            Assert.IsFalse(iHaveEgg.And(iHaveMilk));
            Assert.ThrowsException<Exception>(() => iHaveEgg.And(iHaveMilk).ElseThrow("Error"));

            iHaveEgg = true; iHaveMilk = false;
            Assert.IsFalse(iHaveEgg.And(iHaveMilk));
            Assert.ThrowsException<Exception>(() => iHaveEgg.And(iHaveMilk).ElseThrow("Error"));

            iHaveEgg = false; iHaveMilk = false;
            Assert.IsFalse(iHaveEgg.And(iHaveMilk));
            Assert.ThrowsException<Exception>(() => iHaveEgg.And(iHaveMilk).ElseThrow("Error"));
        }

        [TestMethod]
        public void ShouldTestOrExpression()
        {
            bool iHaveEgg, iHaveMilk;

            iHaveEgg = true; iHaveMilk = true;
            Assert.IsTrue(iHaveEgg.Or(iHaveMilk));

            iHaveEgg = false; iHaveMilk = true;
            Assert.IsTrue(iHaveEgg.Or(iHaveMilk));

            iHaveEgg = true; iHaveMilk = false;
            Assert.IsTrue(iHaveEgg.Or(iHaveMilk));

            iHaveEgg = false; iHaveMilk = false;
            Assert.IsFalse(iHaveEgg.Or(iHaveMilk));
            Assert.ThrowsException<Exception>(() => iHaveEgg.And(iHaveMilk).ElseThrow("Error"));
        }

        [TestMethod]
        public void ShouldTestAndOrExpression()
        {
            bool iHaveEgg, iHaveMilk, iHaveButter;

            iHaveEgg = true; iHaveMilk = true; iHaveButter = true;
            Assert.IsTrue(iHaveEgg.Or(iHaveMilk).And(iHaveButter));

            iHaveEgg = false; iHaveMilk = true; iHaveButter = true;
            Assert.IsTrue(iHaveEgg.Or(iHaveMilk).And(iHaveButter));

            iHaveEgg = true; iHaveMilk = false; iHaveButter = true;
            Assert.IsTrue(iHaveEgg.Or(iHaveMilk).And(iHaveButter));

            iHaveEgg = false; iHaveMilk = true; iHaveButter = true;
            Assert.IsTrue(iHaveEgg.Or(iHaveMilk).And(iHaveButter));

            iHaveEgg = true; iHaveMilk = true; iHaveButter = false;
            Assert.IsFalse(iHaveEgg.Or(iHaveMilk).And(iHaveButter));
            Assert.ThrowsException<Exception>(() => iHaveEgg.And(iHaveMilk).And(iHaveButter).ElseThrow("Error"));

            iHaveEgg = false; iHaveMilk = true; iHaveButter = false;
            Assert.IsFalse(iHaveEgg.Or(iHaveMilk).And(iHaveButter));
            Assert.ThrowsException<Exception>(() => iHaveEgg.And(iHaveMilk).And(iHaveButter).ElseThrow("Error"));

            iHaveEgg = true; iHaveMilk = false; iHaveButter = false;
            Assert.IsFalse(iHaveEgg.Or(iHaveMilk).And(iHaveButter));
            Assert.ThrowsException<Exception>(() => iHaveEgg.And(iHaveMilk).And(iHaveButter).ElseThrow("Error"));

            iHaveEgg = false; iHaveMilk = false; iHaveButter = false;
            Assert.IsFalse(iHaveEgg.Or(iHaveMilk).And(iHaveButter));
            Assert.ThrowsException<Exception>(() => iHaveEgg.And(iHaveMilk).And(iHaveButter).ElseThrow("Error"));
        }

        [TestMethod]
        public void ShouldTestChainedBooleanExpressions()
        {
            bool iHaveEgg, iHaveMilk, iHaveButter;

            iHaveEgg = false; iHaveMilk = true; iHaveButter = true;
            bool iHaveCake = iHaveButter.And(iHaveEgg.And(iHaveMilk)).Or(iHaveEgg);

            Assert.IsFalse(iHaveCake);
        }
    }
}
