using Gerenciador.Models;
using System.ComponentModel.DataAnnotations;

namespace Gerenciador.Dtos
{
    public class CreateActivityDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string? UserId { get; set; }
        [Required]
        public string? ProjectId { get; set; }
        [Required]
        public string? StateId { get; set; }
    }
}
