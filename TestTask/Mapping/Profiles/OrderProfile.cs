using AutoMapper;
using TestTask.Models;
using TestTask.Models.DTO;

namespace TestTask.Mapping.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();
        }
    }
}
