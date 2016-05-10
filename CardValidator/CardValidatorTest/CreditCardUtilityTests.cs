
using CardValidator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CardValidatorTest
{
    [TestClass]
    public class CreditCardUtilityTests
    {
        [TestMethod]
        public void IsCreditCardNumberValid1_True()
        {
            Assert.IsFalse(CreditCardUtility.IsCreditCardNumberValid("555 5555 5555 4444"));
        }
        [TestMethod]
        public void IsCreditCardNumberValid2_True()
        {
            Assert.IsTrue(CreditCardUtility.IsCreditCardNumberValid("3411 3411 3411 347"));
        }
        [TestMethod]
        public void IsCreditCardNumberValid3_True()
        {
            Assert.IsTrue(CreditCardUtility.IsCreditCardNumberValid("3530 1113 3330 0000"));
        }
        [TestMethod]
        public void IsCreditCardNumberValid4_True()
        {
            Assert.IsTrue(CreditCardUtility.IsCreditCardNumberValid("5105 1051 0510 5100"));
        }
        [TestMethod]
        public void IsCreditCardNumberValid5_True()
        {
            Assert.IsTrue(CreditCardUtility.IsCreditCardNumberValid("5000 0000 0000 0611"));
        }
        [TestMethod]
        public void IsCreditCardNumberValid6_True()
        {
            Assert.IsTrue(CreditCardUtility.IsCreditCardNumberValid("4222 2222 222 22"));
        }
        [TestMethod]
        public void IsCreditCardNumberValid7_True()
        {
            Assert.IsTrue(CreditCardUtility.IsCreditCardNumberValid("4111 1111 1111 1111"));
        }
        [TestMethod]
        public void IsCreditCardNumberValid8_True()
        {
            Assert.IsTrue(CreditCardUtility.IsCreditCardNumberValid("4012 8888 8888 1881"));
        }
        [TestMethod]
        public void IsCreditCardNumberValid9_True()
        {
            Assert.IsTrue(CreditCardUtility.IsCreditCardNumberValid("3782 8224 6310 005"));
        }
        [TestMethod]
        public void IsCreditCardNumberValid10_True()
        {
            Assert.IsTrue(CreditCardUtility.IsCreditCardNumberValid("3566 0020 2036 0505"));
        }
    }
}
