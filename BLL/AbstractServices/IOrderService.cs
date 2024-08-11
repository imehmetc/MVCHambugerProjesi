using BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AbstractServices
{
    public interface IOrderService
    {
        Task<OrderDto> CreateNewOrder(OrderDto orderDto);
        Task CreateNewOrderDetail(OrderDetailDto orderDetailDto);
        Task<List<OrderDto>> GetAllOrders();
        Task<OrderDto> GetOrderById(int orderId);
        Task UpdateOrder(int orderId, OrderDto orderDto);
        Task DeleteOrder(int orderId);
        Task RemoveOrder(int orderId);
        Task<List<OrderDto>> GetUserOrders(int userId);
    }
}
