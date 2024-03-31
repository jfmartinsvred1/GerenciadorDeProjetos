using Gerenciador.Models;

namespace Gerenciador.Dtos
{
    public class ReadProjectDto
    {
        public string ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ManagerId { get; set; }
        public ICollection<ProjectUser> ProjectsUsers { get; set; }

        public ICollection<ReadActivityDto> Activity { get; set; }
    }
}
