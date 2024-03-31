namespace Gerenciador.Models
{
    public class Project
    {
        public string ProjectId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Description { get; set; }
        public string ManagerId { get; set; }
        public ICollection<ProjectUser> ProjectsUsers { get; set; }

        public ICollection<Activity> Activity { get; set; }

    }
}
