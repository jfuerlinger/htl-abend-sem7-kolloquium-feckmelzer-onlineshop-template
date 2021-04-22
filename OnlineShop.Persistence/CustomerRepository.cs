using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShop.Core.Contracts;
using OnlineShop.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace OnlineShop.Persistence
{
  public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CustomerRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> GetCountAsync()
        {
            return await _dbContext.Customers.CountAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _dbContext.Customers
                .OrderBy(c => c.LastName)
                .ThenBy(c => c.FirstName)
                .ToListAsync();
        }
    }
}
