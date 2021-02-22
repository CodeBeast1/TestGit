using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI3.Models;

namespace WebAPI3.ICustomerData
{
    public interface ICustomerData
    {
        List<Customer> GetCustomers();

        Customer GetCustomerName(Guid Id);

        Customer AddCustomer(Customer customer);

        void DeleteCustomer(Customer customer);

        Customer GetAccountBalance(Guid iD);
    }
}
