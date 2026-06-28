using System.ComponentModel.DataAnnotations;

namespace ClangLogAPI.Dtos.User
{
    public class CreateUserDto
    {
        [Required]
        public string Username { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
    }
}
