using TestTask.Models.DTO;

namespace TestTask.Services.Interfaces
{
    public interface IOrderService
    {
        //Renamed methods according requirements, because it didnt show the main idea of the methods
        public Task<OrderDTO> GetOrderWithMaxTotalPrice();

        public Task<List<OrderDTO>> GetOrders();
    }
}
