using TestTask.Models;

namespace TestTask.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        //Renamed methods according requirements, because it didnt show the main idea of the methods
        public Task<Order> GetOrderWithMaxTotalPrice();
        public Task<List<Order>> GetOrders();

    }
}
