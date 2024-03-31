using System.ComponentModel.DataAnnotations;

namespace Gerenciador.Models
{
    public class State
    {
        [Key]
        public string StateId { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public string Name { get; set; }
        public ICollection<Activity> Activities { get; set; }
    }
}
