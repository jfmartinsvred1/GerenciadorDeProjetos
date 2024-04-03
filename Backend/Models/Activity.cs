namespace Gerenciador.Models
{
    public class Activity
    {
        public string ActivityId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Description { get; set; }
        public string? UserId { get; set; }
        public virtual User User { get; set; }
        public string? ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public string? StateId { get; set; }
        public virtual State State { get; set; }

    }
}
