﻿using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineShop.Core.Entities;

namespace OnlineShop.Core.Contracts
{
    public interface IOrderItemRepository
    {
        Task<int> GetCountAsync();
        Task AddRangeAsync(IEnumerable<OrderItem> orderItems);
        Task AddAsync(OrderItem orderItem);
        Task RemoveAsync(int id);
    }
}