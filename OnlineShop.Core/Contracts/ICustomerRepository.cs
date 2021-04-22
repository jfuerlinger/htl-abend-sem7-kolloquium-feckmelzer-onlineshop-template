using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineShop.Core.Entities;

namespace OnlineShop.Core.Contracts
{
  public interface ICustomerRepository
    {
        Task<int> GetCountAsync();
        Task<IEnumerable<Customer>> GetAllAsync();
    }
}