using AutoMapper;

namespace UserAPI.Models.DTOs;

public class UserSearchService(IMapper mapper) : ISearchService<UserDTO>
{
    private readonly IUserRepository _userRepository = new UserRepository();

    public UserDTO GetById(int id)
    {
        var res = _userRepository.GetById(id);
        return mapper.Map<UserDTO>(res);
    }

    public UserDTO GetByName(string name)
    {
        var res = _userRepository.GetByName(name);
        return mapper.Map<UserDTO>(res);    }

    public List<UserDTO> GetByAge(int age)
    {
        var res = _userRepository.GetByAge(age);
        return mapper.Map<List<UserDTO>>(res);    
    }
    public UserDTO GetByEmail(string email)
    {
        var res = _userRepository.GetByEmail(email);
        return mapper.Map<UserDTO>(res);    
    }
}