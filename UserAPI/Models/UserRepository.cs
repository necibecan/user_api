namespace UserAPI.Models.DTOs;

public class UserRepository : IUserRepository
{
    private static readonly List<User> Users = new();

    public UserRepository()
    {
        if (Users.Count == 0)
        {
            Users.Add(new User { Id = 1, Name = "User 1", Surname ="surname1", Age = 19, Email = "necibe1@xx.com" });
            Users.Add(new User { Id = 2, Name = "User 2", Surname ="surname2", Age = 23, Email = "necibe2@xx.com", Gender = "Male"});
            Users.Add(new User { Id = 3, Name = "User 3", Surname ="surname3", Age = 43, Email = "necibe3@xx.com" });
            Users.Add(new User { Id = 4, Name = "User 4", Surname ="surname4", Age = 18, Email = "necibe4@xx.com", Gender = "Female"});
            Users.Add(new User { Id = 5, Name = "User 5", Surname ="surname5", Age = 35, Email = "necibe5@xx.com", Gender = "Female"});
        }
    }

    public List<User> GetAll()
    {
        return Users;
    }


    public User Add(User user)
    {
        Users.Add(user);
        return user;
    }

    public User GetById(int id)
    {
        var userIndex = Users.FindIndex(p => p.Id == id);
        return userIndex == -1 ? null : Users[userIndex];
    }    
    
    public User GetByName(string name)
    {
        var userIndex = Users.FindIndex(p => p.Name == name);
        return userIndex == -1 ? null : Users[userIndex];
    }    
    
    public List<User> GetByAge(int age)
    {
        var users = Users.FindAll(p => p.Age == age);
        return users.Count == 0 ? null : users;
    }
    
    public User GetByEmail(string email)
    {
        var userIndex = Users.FindIndex(p => p.Email == email);
        return userIndex == -1 ? null : Users[userIndex];
    }

    public User Update(User user)
    {
        var userToUpdateIndex = Users.FindIndex(p => p.Id == user.Id);
        
        if (userToUpdateIndex == -1) return null;
        
        Users[userToUpdateIndex].Name = user.Name;
        Users[userToUpdateIndex].Surname = user.Surname;
        Users[userToUpdateIndex].Age = user.Age;
        Users[userToUpdateIndex].Email = user.Email;
        Users[userToUpdateIndex].Gender = user.Gender;
        return Users[userToUpdateIndex];
    }

    public bool Delete(int id)
    {
        var userToDeleteIndex = Users.FindIndex(p => p.Id == id);
        if (userToDeleteIndex == -1) return false;
        Users.RemoveAt(userToDeleteIndex);
        return true;
    }
}