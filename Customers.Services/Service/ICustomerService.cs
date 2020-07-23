using Customers.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Services.Service
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerResponseDto>> GetCustomersAsync();
        Task<CustomerResponseDto> GetCustomerAsync(int id);

        Task<CustomerResponseDto> AddCustomerAsync(CustomerRequestDto customer);
    }
}
