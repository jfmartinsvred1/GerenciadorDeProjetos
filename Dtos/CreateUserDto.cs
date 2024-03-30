using System.ComponentModel.DataAnnotations;

namespace Gerenciador.Dtos
{
    public class CreateUserDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password")]
        public string Repassword { get; set; }
    }
}
