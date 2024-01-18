using System.ComponentModel.DataAnnotations;

namespace UserAPI.Models.DTOs;

public class UserDTO
{
    public int Id { get; set; } 

    public string Name { get; set; }

    public string Surname { get; set; }
    
    public int Age { get; set; }

    public string Gender { get; set; }

    private string _email;
    
    public string Email
    {
        get => _email;
        set => _email = value?.ToLowerInvariant();
    }

}