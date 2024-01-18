using AutoMapper;

namespace UserAPI.Models.DTOs;

public class UserService(IMapper mapper) : IUserService
{
    private readonly IUserRepository _userRepository = new UserRepository();
    
    public List<UserDTO> GetAll()
    {
        var userList = _userRepository.GetAll();
        return mapper.Map<List<UserDTO>>(userList);
    }
    
    public UserDTO Add(UserAddRequestDTO user)
    {
        int id = new Random().Next(1, 1000);
        var userToAdd = mapper.Map<UserDTO>(user);
        userToAdd.Id = id;
        var res = _userRepository.Add(mapper.Map<User>(userToAdd));
        return mapper.Map<UserDTO>(res);
    }
    
    public UserDTO Update(UserUpdateRequestDTO user)
    {
        var res = _userRepository.Update(mapper.Map<User>(user));
        return mapper.Map<UserDTO>(res);
    }
    
    public bool Delete(int id)
    {
        return _userRepository.Delete(id);
    }
    
}