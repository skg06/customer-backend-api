using Customers.Shared.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customers.Api.Controllers
{
    public partial class CustomersController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerResponseDto>>> Get()
        {
            var response = await _customerService.GetCustomersAsync();

            return Ok(response);
        }
    }
}
