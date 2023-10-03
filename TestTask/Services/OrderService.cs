using AutoMapper;
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

        public async Task<OrderDTO> GetOrder()
        {
            return _mapper.Map<OrderDTO>(await _orderRepository.GetOrder());
        }

        public async Task<List<OrderDTO>> GetOrders()
        {
            return _mapper.Map<List<OrderDTO>>(await _orderRepository.GetOrders());
        }
    }
}
