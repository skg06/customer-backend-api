using Customers.Shared.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Customers.Api.Controllers
{
    public partial class CustomersController
    {
        [HttpPost]
        public async Task<ActionResult<CustomerResponseDto>> Post(CustomerRequestDto request)
        {
            var response = await _customerService.AddCustomerAsync(request);           
            return Ok(response);
        }
    }
}
