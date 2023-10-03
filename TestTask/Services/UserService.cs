using AutoMapper;
using TestTask.Models.DTO;
using TestTask.Repositories.Interfaces;
using TestTask.Services.Interfaces;

namespace TestTask.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }



        //Get user with the biggest amount of orders
        public async Task<UserDTO> GetUser()
        {
            var user = await _userRepository.GetUser();
            var result = _mapper.Map<UserDTO>(user);
            return result;

        }
        //Get users with the status Inactive
        public async Task<List<UserDTO>> GetUsers()
        {
            var users = await _userRepository.GetUsers();
            return _mapper.Map<List<UserDTO>>(users);
        }
    }
}
