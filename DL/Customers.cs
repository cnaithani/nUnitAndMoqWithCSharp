using System.Collections.Generic;
using System.Linq;
using Model;

namespace DL
{

    public interface ICustomerRepo
    {
        ICustomer getCustomerById(int id);
        List<ICustomer> searchByName(string name);
        
    }
    public class CustomerRepo: ICustomerRepo
    {
        List<ICustomer> customersInDB;

        public CustomerRepo()
        {
            customersInDB = new List<ICustomer>();
            customersInDB.Add(new Model.Customer(1, "A", null, "Z"));
            customersInDB.Add(new Model.Customer(2, "B", "M", "Y"));
            customersInDB.Add(new Model.Customer(3, "C", "N", "X"));
            customersInDB.Add(new Model.Customer(4, "D", "O", "W"));
            customersInDB.Add(new Model.Customer(5, "E", "P", "V"));
        }


        public ICustomer getCustomerById(int id)
        {
            return customersInDB.Where(x => x.id == id).FirstOrDefault();
        }

        public List<ICustomer> searchByName(string name)
        {
            return customersInDB.Where(x => x.firstName.Contains(name) || x.middleName.Contains(name) || x.lastName.Contains(name)).ToList<ICustomer>();
        }
    }
}
