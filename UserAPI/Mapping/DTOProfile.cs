using AutoMapper;
using UserAPI.Models.DTOs;

namespace WebApplication1.Mapping;

public class DtoProfile : Profile
{
    public DtoProfile()
    {
        CreateMap<User, UserDTO>().ReverseMap();
        CreateMap<UserUpdateRequestDTO, User>().ReverseMap();
        CreateMap<UserAddRequestDTO, UserDTO>().ReverseMap();
    }
}