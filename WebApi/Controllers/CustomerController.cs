using Contracts.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions.Customer;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        #region Property  
        private readonly ICustomerApplicationService _customerApplicationService;
        #endregion

        #region Constructor  
        public CustomerController(ICustomerApplicationService customerApplicationService)
        {
            _customerApplicationService = customerApplicationService;
        }
        #endregion

        [HttpGet(nameof(GetCustomer))]
        public IActionResult GetCustomer(int id)
        {
            var result = _customerApplicationService.GetCustomer(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpGet(nameof(GetAllCustomer))]
        public IActionResult GetAllCustomer()
        {
            var result = _customerApplicationService.GetAllCustomers();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpPost(nameof(InsertCustomer))]
        public IActionResult InsertCustomer(CustomerDto customer)
        {
            _customerApplicationService.InsertCustomer(customer);
            return Ok("Data inserted");

        }
        [HttpPut(nameof(UpdateCustomer))]
        public IActionResult UpdateCustomer(CustomerDto customer)
        {
            _customerApplicationService.UpdateCustomer(customer);
            return Ok("Updation done");

        }
        [HttpDelete(nameof(DeleteCustomer))]
        public IActionResult DeleteCustomer(int Id)
        {
            _customerApplicationService.DeleteCustomer(Id);
            return Ok("Data Deleted");

        }
    }
}
