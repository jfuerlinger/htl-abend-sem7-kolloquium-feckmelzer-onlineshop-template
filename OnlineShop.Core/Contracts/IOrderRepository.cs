﻿using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineShop.Core.DTOs;
using OnlineShop.Core.Entities;

namespace OnlineShop.Core.Contracts
{
    public interface IOrderRepository
    {
        Task<int> GetCountAsync();
        Task<IEnumerable<OrderDto>> GetAllAsync();

        Task<IEnumerable<OrderWithItemsDto>> GetAllWithItemsAsync();
        Task<OrderDto> FindAsync(int id);

        Task<OrderWithItemsDto> GetOrderWithItems(int id);

        Task<IEnumerable<OrderWithItemsDto>> GetOrdersByCustomer(int id);
        Task<IEnumerable<OrderDto>> GetFilteredForCustomers(string lastNameFilter);
        Task RemoveAsync(int orderId);
        Task AddAsync(Order order);
    }
}