using Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions.Customer
{
    public interface ICustomerApplicationService
    {
        void DeleteCustomer(int id);

        IEnumerable<CustomerDto> GetAllCustomers();

        CustomerDto GetCustomer(int id);

        void InsertCustomer(CustomerDto customer);

        void UpdateCustomer(CustomerDto customer);
    }
}
