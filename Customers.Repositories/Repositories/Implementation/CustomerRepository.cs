using Customers.Infrastructure;

using Customers.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customers.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context)
            :base(context) { }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _dataContext.Customers.ToListAsync();
        }
        public async Task<Customer> GetCustomerAsync(int id)
        {
            return await _dataContext.Customers.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            await _dataContext.Customers.AddAsync(customer);
            await _dataContext.SaveChangesAsync();
            return customer;
        }
    }
}
