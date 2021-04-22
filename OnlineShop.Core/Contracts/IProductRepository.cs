using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineShop.Core.DTOs;
using OnlineShop.Core.Entities;

namespace OnlineShop.Core.Contracts
{
  public interface IProductRepository
    {
        Task<int> GetCountAsync();
        Task AddRangeAsync(IEnumerable<Product> products);
        Task<IEnumerable<ProductDto>> GetAllAsync();
        Task<Product> GetAsync(int productId);
        Task AddAsync(Product product);
    }
}