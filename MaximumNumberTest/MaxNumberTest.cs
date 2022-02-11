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
            int check1 = test1.MaxNumCheck(30,20,10);
            Assert.AreEqual(3, check1);
        }

         [Test]
        public void InputValue_IsMax_ReturnMax()
        {
            int check2 = test1.MaxNumCheck(10,30,20);
            Assert.AreEqual(3, check2);
        }

         [Test]
        public void InputValue_IsMax_ReturnMax()
        {
            int check3 = test1.MaxNumCheck(10,20,30);
            Assert.AreEqual(3, check3);
        }
    }
}