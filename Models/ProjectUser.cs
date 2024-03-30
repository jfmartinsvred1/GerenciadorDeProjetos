using System.ComponentModel.DataAnnotations.Schema;

namespace Gerenciador.Models
{
    public class ProjectUser
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public string? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
