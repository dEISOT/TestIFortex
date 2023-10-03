using TestTask.Models;

namespace TestTask.Repositories.Interfaces
{
    public interface IUserRepository
    {
        //Renamed methods according requirements, because it didnt show the main idea of the methods
        public Task<User> GetUserWithMaxOrderCount();
        public Task<List<User>> GetInactiveUsers();
    }
}
