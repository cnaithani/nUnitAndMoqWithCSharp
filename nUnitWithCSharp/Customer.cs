using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using Model;

namespace nUnitWithCSharp
{
    public class Customer
    {
        public Customer(ICustomerRepo cusRepo)
        {
            this.CustomerRepo = cusRepo;
        }

        public ICustomerRepo CustomerRepo{get;set;}


        public ICustomer getCustomerById(int id)
        {
            var customer = CustomerRepo.getCustomerById(id);
            if (customer.middleName == null)
            {
                customer.middleName = string.Empty;
                customer.fullName = customer.firstName + (customer.middleName == null ? " " + customer.middleName : string.Empty) + " " + customer.lastName;
            }
            else
            {
                customer.fullName = customer.firstName + " " + customer.middleName  + customer.lastName;
            }
                
            return customer;
        }

        public List<ICustomer> searchByName(string name)
        {
            var customers = CustomerRepo.searchByName(name);
            foreach (var oCus in customers)
                if (oCus.middleName == null)
                    oCus.middleName = string.Empty;

            return customers;
        }
    }
}
