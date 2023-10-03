using AutoMapper;
using TestTask.Models;
using TestTask.Models.DTO;

namespace TestTask.Mapping.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
