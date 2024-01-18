using System.ComponentModel.DataAnnotations;

namespace UserAPI.Models.DTOs;

public class UserAddRequestDTO
{
    [Required(ErrorMessage="Name field cannot be empty.")] 
    public string Name { get; set; }

    [Required(ErrorMessage="Surname field cannot be empty.")] 
    public string Surname { get; set; }

    [Required(ErrorMessage="Age field cannot be empty.")] 
    [Range(18, 64, ErrorMessage = "Age must be in range (18, 64)")] 
    public int Age { get; set; }

    public string Gender { get; set; }

    private string _email;

    [Required(ErrorMessage="Email field cannot be empty.")]
    [EmailAddress(ErrorMessage = "Invalid Email")]
    public string Email
    {
        get => _email;
        set => _email = value?.ToLowerInvariant(); // E-posta adresini küçük harflere çevir
    }
}