using Contracts.DtoMappers;
using Contracts.Dtos;
using Domain.Models;
using DomainService;
using Services.Abstractions.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CustomerApplicationService : ICustomerApplicationService
    {
        ICustomerService _domainService;
        IEntityMapper<Customer, CustomerDto> mapper;

        public CustomerApplicationService(ICustomerService domainService, IEntityMapper<Customer, CustomerDto> customerMapper)
        {
            _domainService = domainService;
            mapper = customerMapper;
        }
        void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        void ICustomerApplicationService.DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<CustomerDto> GetAllCustomers()
        {
            IList<CustomerDto> res = new List<CustomerDto>();
            foreach (var item in _domainService.GetAllCustomers())
                res.Add(mapper.MapTo(item));
            return res;
        }

        IEnumerable<CustomerDto> ICustomerApplicationService.GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        CustomerDto GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        CustomerDto ICustomerApplicationService.GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        void InsertCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();
        }

        void ICustomerApplicationService.InsertCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();
        }

        void UpdateCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();
        }

        void ICustomerApplicationService.UpdateCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();
        }
    }
}
