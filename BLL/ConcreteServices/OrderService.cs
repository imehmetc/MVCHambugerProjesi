using AutoMapper;
using BLL.AbstractServices;
using BLL.Dtos;
using DAL.AbstractRepositories;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ConcreteServices
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<Menu> _menuRepository;
        private readonly IRepository<OrderDetail> _orderDetailRepository;
        private readonly IMapper _mapper;

        public OrderService(IRepository<Order> orderRepository,IRepository<Menu> menuRepository, IRepository<OrderDetail> orderDetailRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _menuRepository = menuRepository;
            _orderDetailRepository = orderDetailRepository;
            _mapper = mapper;
        }
        public async Task<OrderDto> CreateNewOrder(OrderDto orderDto) 
        {
            var order = _mapper.Map<Order>(orderDto);
            await _orderRepository.AddAsync(order);
            return _mapper.Map<OrderDto>(order);

        }

        public async Task CreateNewOrderDetail(OrderDetailDto orderDetailDto)
        {
            await _orderDetailRepository.AddAsync(_mapper.Map<OrderDetail>(orderDetailDto));
        }

        public Task DeleteOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDto>> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Task<OrderDto> GetOrderById(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDto>> GetUserOrders(int userId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrder(int orderId, OrderDto orderDto)
        {
            throw new NotImplementedException();
        }
    }
}
