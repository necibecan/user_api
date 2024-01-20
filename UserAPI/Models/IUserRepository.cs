namespace UserAPI.Models.DTOs;

public interface IUserRepository
{
    List<User> GetAll();
    User Add(User user);
    User GetById(int id);
    User GetByName(string name);
    User GetByEmail(string email);
    List<User> GetByAge(int age);
    User Update(User user);
    bool Delete(int id);
}