using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Models;
using TestTask.Repositories.Interfaces;

namespace TestTask.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        //INFO: Better to add field total price in Order model. It will optimize get request
        //Renamed methods according requirements, because it didnt show the main idea of the methods
        public async Task<Order> GetOrderWithMaxTotalPrice()
        { 
            return await _context.Orders.OrderByDescending(order => order.Price * order.Quantity).FirstOrDefaultAsync();
        }

        public async Task<List<Order>> GetOrders()
        {
           return await _context.Orders.Where(order => order.Quantity > 10).ToListAsync();
        }
    }
}
