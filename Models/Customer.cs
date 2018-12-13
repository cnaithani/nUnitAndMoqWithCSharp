using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ICustomer
    {
        int id { get; set; }
        string firstName { get; set; }
        string middleName { get; set; }
        string lastName { get; set; }
        string fullName { get; set; }
    }


    public class Customer:ICustomer
    {

        public Customer(int id,string firstName, string middleName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
        }
        public int id { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string fullName { get; set; }


    }
}
