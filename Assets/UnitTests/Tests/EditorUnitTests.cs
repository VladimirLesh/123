using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class EditorUnitTests
    {
        private int startVal = 7;
        private TestClass test;

        [SetUp]
        public void SetUp()
        {
            test = new TestClass(startVal);
        }

        [Test]
        public void UnitTest_isConstructorCorrect()
        {
            int val = test.GetCurrrentVal();
            Assert.AreEqual(startVal, val);
        }
        [Test]
        public void UnitTest_isAddingCorrect()
        {
            int val = test.GetCurrrentVal() + 5;
            Assert.AreEqual(test.AddFive(), val);
        }

        [TearDown]
        public void End()
        {
            test = null;
        }
    }
}
