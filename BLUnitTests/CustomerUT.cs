using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Moq;
using DL;
using Model;
using nUnitWithCSharp;

namespace BLUnitTests
{
    [TestFixture]
    public class CustomerUT
    {
        [Test]
        public void getCustomerByIdTest()
        {
            Mock<ICustomerRepo> cusRepoMock = new Mock<ICustomerRepo>();
            ICustomer cus1 = new Model.Customer(1, "A", null, "Z");
            ICustomer cus2 = new Model.Customer(2, "B", "S", "Y");

            cusRepoMock.Setup(x => x.getCustomerById(1)).Returns(cus1);
            cusRepoMock.Setup(x => x.getCustomerById(2)).Returns(cus2);

            var cusRepo = new nUnitWithCSharp.Customer(cusRepoMock.Object);
            Assert.IsNotNull(cusRepo, "Customer repository object not initiated correctly.");
            var cus3 = cusRepo.getCustomerById(1);
            Assert.IsNotNull(cus3, "Customer object not initiated correctly.");
            Assert.IsNotNull(cus3.fullName, "Customer full name not correct.");
            Assert.AreEqual(cus3.fullName, "A Z", "Customer full name not correct.");


            var cus4 = cusRepo.getCustomerById(2);
            Assert.AreEqual(cus4.fullName, "B S Y", "Customer full name not correct.");


            var cus5 = cusRepo.getCustomerById(0);
            Assert.IsNull(cus5, "Customer object is incorrectly initiated");

        }
    }
}

