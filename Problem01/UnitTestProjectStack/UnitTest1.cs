using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem02;

namespace UnitTestProjectStack
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPush()
        {
            Stack S = new Stack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual(3, S.Count());
        }

        [TestMethod]
        public void TestPop()
        {
            Stack S = new Stack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual("3", S.Pop());
            Assert.AreEqual("2", S.Pop());
        }

        [TestMethod]
        public void TestPeek()
        {
            //Push some items, check Peeked value and Count
            Stack S = new Stack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual("3", S.Peek());
            Assert.AreEqual(3, S.Count());
        }

        [TestMethod]
        public void TestClear()
        {
            //Invoke clear and check Count
            Stack S = new Stack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            S.Clear();
            Assert.AreEqual(0, S.Peek());
           
        }
    }
}
