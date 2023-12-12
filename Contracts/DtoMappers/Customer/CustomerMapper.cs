using Contracts.Dtos;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.DtoMappers
{
    public class CustomerMapper : IEntityMapper<Customer, CustomerDto>
    {
        Customer IEntityMapper<Customer, CustomerDto>.CreateFrom(CustomerDto destination)
        {
            throw new NotImplementedException();
        }

        CustomerDto IEntityMapper<Customer, CustomerDto>.MapTo(Customer source)
        {
            throw new NotImplementedException();
        }
    }
}
