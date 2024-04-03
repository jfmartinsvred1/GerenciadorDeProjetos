using Gerenciador.Models;

namespace Gerenciador.Dtos
{
    public class ReadActivityDto
    {
        public string ActivityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ReadUsersDto User { get; set; }
        public virtual Project Project { get; set; }
        public virtual State State { get; set; }
    }
}
