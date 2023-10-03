using AutoMapper;
using Serilog;
using TestTask.Exceptions;
using TestTask.Models;
using TestTask.Models.DTO;
using TestTask.Repositories.Interfaces;
using TestTask.Services.Interfaces;

namespace TestTask.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;


        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }
        //Renamed methods according requirements, because it didnt show the main idea of the methods
        public async Task<OrderDTO> GetOrderWithMaxTotalPrice()
        {
            var order = _mapper.Map<OrderDTO>(await _orderRepository.GetOrderWithMaxTotalPrice());
            if (order == null)
            {
                Log.Information($"order with order id {order.Id} not found");

                throw new OrderNotFoundException();
            }
            return order;
        }

        public async Task<List<OrderDTO>> GetOrders()
        {
            var order = _mapper.Map<List<OrderDTO>>(await _orderRepository.GetOrders());
            if (order == null)
            {
                Log.Information($"orders not found");

                throw new OrderNotFoundException();
            }
            return order;
        }
    }
}
