using TestTask.Models.DTO;

namespace TestTask.Services.Interfaces
{
    public interface IOrderService
    {
        public Task<OrderDTO> GetOrder();

        public Task<List<OrderDTO>> GetOrders();
    }
}
