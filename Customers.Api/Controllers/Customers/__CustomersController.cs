using AutoMapper;
using Customers.Services.Service;
using Microsoft.AspNetCore.Mvc;

namespace Customers.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class CustomersController : ControllerBase
    {
        protected readonly ICustomerService _customerService;
        protected readonly IMapper _mapper;
        public CustomersController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }
        
    }
}
