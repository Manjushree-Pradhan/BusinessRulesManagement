using System;
using BusinessRuleManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessEngineTestProject
{
    [TestClass]
    public class BusinessEngineUnitTest
    {
        [TestMethod]
        public void PhysicalProductPaymentTest()
        {
            //generate a packing slip for shipping
            PaymentModule product = new PaymentModule(new PhysicalProduct());
            bool result = product.PayForTheProduct(0.0);
            Assert.Equals(result, true);
        }

        [TestMethod]
        public void BookPaymentTest()
        {
            //generate a duplicate packing slip for royalty department
            PaymentModule product = new PaymentModule(new Book());
            bool result = product.PayForTheProduct(0.0);
            Assert.Equals(result, true);
        }

        [TestMethod]
        public void MembershipPaymentTest()
        {
            PaymentModule product = new PaymentModule(new Membership());
            bool result =  product.PayForTheProduct(0.0);
            Assert.Equals(result, true);
        }

        [TestMethod]
        public void UpgradeToMembershipPaymentTest()
        {
            PaymentModule product = new PaymentModule(new UpgradeToMembership());
            bool result = product.PayForTheProduct(0.0);
            Assert.Equals(result, true);
        }

        [TestMethod]
        public void MembershipOrUpgradePaymentTest()
        {

        }

        [TestMethod]
        public void VideoToSkiPaymentTest()
        {
            PaymentModule product = new PaymentModule(new VideoToSki());
            bool result =  product.PayForTheProduct(0.0);
            Assert.Equals(result, true);
        }

        [TestMethod]
        public void BookOrPhysicalProductPaymentTest()
        {

        }

    }
}
