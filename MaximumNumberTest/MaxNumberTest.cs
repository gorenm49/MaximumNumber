using System;
using NUnit.Framework;

namespace MaximumNumberTest
{
    public class MaxNumberTest
    {
        MaximumNumberCheck test1 = new MaximumNumberCheck();
        [Test]
        public void InputValue_IsMax_ReturnMax()
        {
            float check1 = test1.MaxNumCheck(30.4,20.5,10.5);
            Assert.AreEqual(3, check1);
        }

         [Test]
        public void InputValue_IsMax_ReturnMax()
        {
            float check2 = test1.MaxNumCheck(10.5,30.4,20.5);
            Assert.AreEqual(3, check2);
        }

         [Test]
        public void InputValue_IsMax_ReturnMax()
        {
            float check3 = test1.MaxNumCheck(20.5,10.5,30.4);
            Assert.AreEqual(3, check3);
        }
    }
}