using System.ComponentModel.DataAnnotations;

namespace Gerenciador.Models
{
    public class State
    {
        [Key]
        public Guid StateId { get; set; } = Guid.NewGuid();
        [Required]
        public string Name { get; set; }
    }
}
