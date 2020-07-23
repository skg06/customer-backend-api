using AutoMapper;
using Customers.Infrastructure.Data.Entities;
using Customers.Shared.Dto;

namespace Customers.Services.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            this.CreateMap<Customer, CustomerResponseDto>();
            this.CreateMap<CustomerResponseDto, Customer>();

            this.CreateMap<Customer, CustomerRequestDto>();
            this.CreateMap<CustomerRequestDto, Customer>();
        }
    }
}
