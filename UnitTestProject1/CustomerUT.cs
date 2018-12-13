using DL;
using Model;
using NUnit.Framework;

namespace DL.Tests
{
   
    [TestFixture]
    public class CustomerUT
    {
      

        [Test]
        public void getCustomerByIdTest()
        {
            ICustomerRepo cusRepo = new CustomerRepo();
            ICustomer customer = cusRepo.getCustomerById(1);
            Assert.IsNotNull(customer,"Customer object not initiated correctly.");
            Assert.IsInstanceOf(typeof(ICustomer), customer, "Customer object not of correct type.");
        }

       
    }
}




