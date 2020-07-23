using Customers.Shared.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Customers.Api.Controllers
{
    public partial class CustomersController
    {
        [HttpGet("{id:int}")]
        public async Task<ActionResult<CustomerResponseDto>> Get(int id)
        {
            var response = await _customerService.GetCustomerAsync(id);
            return Ok(response);
        }
    }
}
