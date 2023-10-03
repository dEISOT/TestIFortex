using TestTask.Models.DTO;

namespace TestTask.Services.Interfaces
{
    public interface IUserService
    {
        public Task<UserDTO> GetUser();

        public Task<List<UserDTO>> GetUsers();
    }
}
