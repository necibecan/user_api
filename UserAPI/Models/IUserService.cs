
namespace UserAPI.Models.DTOs;

public interface IUserService
{
    List<UserDTO> GetAll();
    UserDTO Add(UserAddRequestDTO user);
    UserDTO Update(UserUpdateRequestDTO user);
    bool Delete(int id);
}