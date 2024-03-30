using Gerenciador.Models;

namespace Gerenciador.Dtos
{
    public class CreateProjectUserDto
    {
        public string? ProjectId { get; set; }
        public string? UserId { get; set; }
    }
}
