using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Models;
using TestTask.Repositories.Interfaces;

namespace TestTask.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public async Task<Order> GetOrder()
        { 
            return await _context.Orders.OrderByDescending(order => order.Price * order.Quantity).FirstOrDefaultAsync();
        }

        public async Task<List<Order>> GetOrders()
        {
           return await _context.Orders.Where(order => order.Quantity > 10).ToListAsync();
        }
    }
}
