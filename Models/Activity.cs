﻿namespace Gerenciador.Models
{
    public class Activity
    {
        public Guid ActivityId { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public string? UserId { get; set; }
        public virtual User User { get; set; }
        public string? ProjectId { get; set; }
        public virtual Project Project { get; set; }

    }
}