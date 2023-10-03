using TestTask.Models.DTO;

namespace TestTask.Services.Interfaces
{
    public interface IUserService
    {
        //Renamed methods according requirements, because it didnt show the main idea of the methods
        public Task<UserDTO> GetUserWithMaxOrderCount();

        public Task<List<UserDTO>> GetInactiveUsers();
    }
}
