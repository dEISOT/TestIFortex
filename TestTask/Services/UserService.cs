using AutoMapper;
using Serilog;
using TestTask.Exceptions;
using TestTask.Models;
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
        //Renamed methods according requirements, because it didnt show the main idea of the methods
        //Get user with the biggest amount of orders
        public async Task<UserDTO> GetUserWithMaxOrderCount()
        {
            var user = _mapper.Map<UserDTO>(await _userRepository.GetUserWithMaxOrderCount());
            if (user == null)
            {
                Log.Information($"user with order id {user.Id} not found");

                throw new OrderNotFoundException();
            };
            return user;

        }
        //Get users with the status Inactive
        public async Task<List<UserDTO>> GetInactiveUsers()
        {
            var users = _mapper.Map<List<UserDTO>>( await _userRepository.GetInactiveUsers());
            if (users == null)
            {
                Log.Information($"users not found");

                throw new OrderNotFoundException();
            }
            return users;
        }
    }
}
