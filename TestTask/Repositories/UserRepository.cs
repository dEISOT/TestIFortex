using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Models;
using TestTask.Repositories.Interfaces;

namespace TestTask.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        //Renamed methods according requirements, because it didnt show the main idea of the methods
        public async Task<User> GetUserWithMaxOrderCount()
        {
            return await _context.Users.OrderByDescending(u => u.Orders.Count()).FirstOrDefaultAsync();
        }

        public async Task<List<User>> GetInactiveUsers()
        {
            return await _context.Users.Where(u => u.Status == Enums.UserStatus.Inactive).ToListAsync();
        }
    }
}
