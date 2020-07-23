using System.Collections.Generic;
using System.Threading.Tasks;
using Customers.Infrastructure.Data.Entities;
namespace Customers.Repositories
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Task<IEnumerable<Customer>> GetCustomersAsync();
        Task<Customer> GetCustomerAsync(int id);
        Task<Customer> AddCustomerAsync(Customer customer);
    }
}
