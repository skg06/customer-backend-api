using AutoMapper;
using Customers.Infrastructure.Data.Entities;
using Customers.Repositories;
using Customers.Shared.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customers.Services.Service.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CustomerResponseDto>> GetCustomersAsync()
        {
            var result = await _customerRepository.GetCustomersAsync();
            return _mapper.Map<IEnumerable<CustomerResponseDto>>(result);
        }

        public async Task<CustomerResponseDto> GetCustomerAsync(int id)
        {
            var result = await _customerRepository.GetCustomerAsync(id);
            return _mapper.Map<CustomerResponseDto>(result);
        }

        public async Task<CustomerResponseDto> AddCustomerAsync(CustomerRequestDto customerDto)
        {
            var customer = _mapper.Map<CustomerRequestDto, Customer>(customerDto);
            var result = await _customerRepository.AddCustomerAsync(customer);
            return _mapper.Map<CustomerResponseDto>(result);
        }
    }
}
